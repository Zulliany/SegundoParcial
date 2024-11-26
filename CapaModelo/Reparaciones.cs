using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaMantenimientoEquipos.CapaModelo
{
    public class Reparaciones
    {
        public static int ReparacionID { get; set; }
        public static string EquipoID { get; set; }
        public static string FechaSolicitud { get; set; }
        public static string Estado { get; set; }
    }
}