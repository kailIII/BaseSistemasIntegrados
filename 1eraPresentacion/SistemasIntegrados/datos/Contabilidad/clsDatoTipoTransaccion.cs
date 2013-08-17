﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Contabilidad;
using datos.Seguridad;
namespace datos.Contabilidad
{
    public class clsDatoTipoTransaccion
    {

        public List<clsTipoTransaccion> Consulta()
        {
            try
            {
                List<clsTipoTransaccion> lista = new List<clsTipoTransaccion>();
                EntitiesContabilidad ent = new EntitiesContabilidad();
                var tipotran = from tt in ent.TipoTransaccion select tt;
                foreach (var item in tipotran)
                {
                    clsTipoTransaccion ctipo = new clsTipoTransaccion();
                    //las variables puden ser nulas u no soportan el tipo de dato int por eso se realiza el convert
                    ctipo.IdTransaccion = Convert.ToInt32(item.IdTransaccion);
                    ctipo.modulo = item.modulo;
                    ctipo.TipoDocumento = item.TipoDocumento;
                    ctipo.descripcion = item.descripcion;
                    lista.Add(ctipo);

                }
                return lista;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<clsModulo> ConsultaModulo()
        {
            try
            {
                List<clsModulo> lista = new List<clsModulo>();
                //EntitiesContabilidad ent = new EntitiesContabilidad();
                //var tipotran = from tt in ent.Modulo select tt;
                TECAv8Entities ent = new TECAv8Entities();
                var tipotran = from tt in ent.Modulo select tt;
                foreach (var item in tipotran)
                {
                    clsModulo ctipo = new clsModulo();
                    //las variables puden ser nulas u no soportan el tipo de dato int por eso se realiza el convert
                    ctipo.IdModulo = Convert.ToInt32(item.IdModulo);
                    ctipo.Nombre = item.Nombre;
                    ctipo.IdEstado = Convert.ToInt32(item.IdEstado);
                    ctipo.Logo = item.Logo;
                    lista.Add(ctipo);

                }
                return lista;
            }
            catch (Exception)
            {

                return null;
            }
        }

        //MANTENIMIENTO MODIFICAR
        public void modificar(clsTipoTransaccion tiptran)
        {
            using (EntitiesContabilidad ent = new EntitiesContabilidad())
            {
                var x = (from q in ent.TipoTransaccion where q.IdTransaccion == tiptran.IdTransaccion select q).First();
                x.modulo = tiptran.modulo;
                x.TipoDocumento = tiptran.TipoDocumento;
                x.descripcion = tiptran.descripcion;
                ent.SaveChanges();
            }

        }

        //MANTENIMIENTO GUARDAR
        public void guardar(clsTipoTransaccion tiptran)
        {
            using (EntitiesContabilidad ent = new EntitiesContabilidad())
            {
                TipoTransaccion tt = new TipoTransaccion()
                {
                    IdTransaccion = tiptran.IdTransaccion,
                    modulo = tiptran.modulo,
                    TipoDocumento = tiptran.TipoDocumento,
                    descripcion = tiptran.descripcion

                };
                ent.AddToTipoTransaccion(tt);
                ent.SaveChanges();

            }
        }


        //MANTENIMIENTO ELIMIAR
        public void eliminar(clsTipoTransaccion tiptran)
        {
            using (EntitiesContabilidad ent = new EntitiesContabilidad())
            {
                var x = (from q in ent.TipoTransaccion where q.IdTransaccion == tiptran.IdTransaccion select q).First();
                ent.DeleteObject(x);
                ent.SaveChanges();
            }
        }
    }
}