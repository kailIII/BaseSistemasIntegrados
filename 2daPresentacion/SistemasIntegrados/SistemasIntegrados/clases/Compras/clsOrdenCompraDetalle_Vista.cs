﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Compras
{
    public class clsOrdenCompraDetalle_Vista
    {
        public int Numero { get; set; }
        public int linea { get; set; }
        public int id_articulo { get; set; }
        public string Articulo { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        public int Id_empresa { get; set; }
        public string Empresa { get; set; }


        public clsOrdenCompraDetalle_Vista()
        {

        }  



    }
}