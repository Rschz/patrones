using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace patrones.DAO
{
    class ConexionBD
    {
        protected SqlConnection Conexion = new SqlConnection("Server=MSI\\EXPRESS; DataBase=db_patrones;Integrated Security=True");
    }
}
