﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Cuentasxpagar
{
    public class clsOrdenPagoCab
    {
        public int NumOrdenPago { get; set; }
        public DateTime fechadeEmision { get; set; }
        public int IdPersona { get; set; }
        public decimal TotalPagar { get; set; }
        public string TipoOrdenPago { get; set; }
        public int Estado { get; set; }
        public int IdEmpresa { get; set; }
        public int IdUsuario { get; set; }

        public clsOrdenPagoCab()
        {
        }


    }
}