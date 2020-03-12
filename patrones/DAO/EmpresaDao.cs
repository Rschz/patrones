using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using patrones.DTO;


namespace patrones.DAO
{
    class EmpresaDao:ConexionBD
    {
        SqlDataReader LeerFilas;
        SqlCommand Comando = new SqlCommand();

        //METODOS CRUD
        public List<EmpresasDto> VerRegistros(string param)
        {
            Comando.Connection = Conexion;
            Comando.CommandText = "VerRegistros";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@parametro", param);

            Conexion.Open();

            LeerFilas = Comando.ExecuteReader();
            List<EmpresasDto> ListadoEmpresas = new List<EmpresasDto>();

            while (LeerFilas.Read())
            {
                ListadoEmpresas.Add(new EmpresasDto {
                    EmpresaID = LeerFilas.GetInt32(0),
                    Nombre = LeerFilas.GetString(1),
                    Correo = LeerFilas.GetString(2),
                    Direccion = LeerFilas.GetString(3),
                    Postal = LeerFilas.GetString(4)
                });
            }

            LeerFilas.Close();
            Conexion.Close();

            return ListadoEmpresas;
        }

    }
}
