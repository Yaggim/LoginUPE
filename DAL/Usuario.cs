using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class Usuario
    {
        public DataTable IniciarSesion()
        {

            Conexion conexion = new Conexion();

            DataTable dt = conexion.LeerPorComando("SELECT usuario, clave FROM [Universidad].[dbo].[Usuario]");

            return dt;
        }
    }
}
