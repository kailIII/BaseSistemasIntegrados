﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.Inventario;
using datos.Inventario;

namespace forms.Inventario
{
    public partial class frmConsultaTipoArticulo : Form
    {
        public frmConsultaTipoArticulo()
        {
            InitializeComponent();
            cargarTabla();

        }
        void frmConsultaTipoArticulo_Event_frmConsultaTipoArticulo_FormClosing(object sender, EventArgs e)
        {
        }

        void frmConsultaTipoArticulo_Event_frmConsultaTipoArticulo_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        public void cargarTabla()
        {
            datTipoArticulo cd = new datTipoArticulo();
            var ListTipoArticulo = cd.consulta();
            ListTipoArticulo.ForEach(v => { v.estado = (v.estado == "1") ? "Activo" : "Inactivo"; });
            gdcConsultaTipoArticulo.DataSource = ListTipoArticulo;
        }


        public clsTipoArticulo clastm = new clsTipoArticulo();
        public void get()
        {
            clastm.empresa = Convert.ToInt32(gridView1.GetFocusedRowCellValue(Empresa));
            clastm.codigo = Convert.ToInt32(gridView1.GetFocusedRowCellValue(Codigo));
            clastm.descripcion = Convert.ToString(gridView1.GetFocusedRowCellValue(Descripcion));
            //clastm.usuario = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colusuario));
            clastm.estado = Convert.ToString(gridView1.GetFocusedRowCellValue(Estado));
        }



        private void frmConsultaTipoArticulo_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void tsbNuevaConsulta_Click(object sender, EventArgs e)
        {
            frmTipoArticulo cInv = new frmTipoArticulo();
            get();
            cInv.cTipoArticulo = clastm;
            cInv.accion = "G";

            cInv.ShowDialog();
        }

        private void tsbModificarConsulta_Click(object sender, EventArgs e)
        {
            frmTipoArticulo cInv = new frmTipoArticulo();
            get();
            cInv.cTipoArticulo = clastm;
            cInv.accion = "M";

            cInv.ShowDialog();
        }

        private void tsbEliminarConsulta_Click(object sender, EventArgs e)
        {
            frmTipoArticulo cInv = new frmTipoArticulo();
            get();
            cInv.cTipoArticulo = clastm;
            cInv.accion = "E";

            cInv.ShowDialog();
        }

        private void tsbCargarConsulta_Click(object sender, EventArgs e)
        {
            cargarTabla();
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            clsTipoArticulo TipoArticulo = (clsTipoArticulo)gridView1.GetFocusedRow();
            Event_frmConsultaTipoArticulo_FormClosing(TipoArticulo, e);
            //  Close();|
        }

        public delegate void delegate_frmConsultaTipoArticulo_FormClosing(object sender, EventArgs e);
        public event delegate_frmConsultaTipoArticulo_FormClosing Event_frmConsultaTipoArticulo_FormClosing;
        private void frmConsultaTipoArticulo_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            clastm = getRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            Close();
        }

        private clsTipoArticulo getRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (clsTipoArticulo)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}