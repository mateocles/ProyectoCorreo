using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion
{
    public class Conexion
    {
        private static MySqlConnection conexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["connect"].ConnectionString);
        private static bool Conectar()
        {
            try
            {
                conexion.Open();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        private static void Desconectar()
        {
            conexion.Close();
        }

        public static bool EjecutarOperacion(string sentencia, List<MySqlParameter> ListaParametros, CommandType TipoComando)
        {
            if (Conectar())
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = sentencia;
                comando.CommandType = TipoComando;
                comando.Connection = conexion;
                foreach (MySqlParameter parametro in ListaParametros)
                {
                    comando.Parameters.Add(parametro);
                }

                try
                {
                    comando.ExecuteNonQuery();
                }
                catch (MySqlException)
                {
                    return false;
                }

                Desconectar();
                return true;
            }





            throw new Exception("No ha sido posible conectarse a la Base de Datos");

        }


        public static DataTable EjecutarConsulta(string sentencia, List<MySqlParameter> ListaParametros, CommandType TipoComando)
        {
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = new MySqlCommand(sentencia, conexion);
            adaptador.SelectCommand.CommandType = TipoComando;

            foreach (MySqlParameter parametro in ListaParametros)
            {
                adaptador.SelectCommand.Parameters.Add(parametro);
            }
            DataSet resultado = new DataSet();
          
            adaptador.Fill(resultado);
            
            try {
             return   resultado.Tables[0];
                    } catch (Exception)
            {
                
            }
            return null;

        }


        public string cad_Conexion()
        {
            return ConfigurationManager.ConnectionStrings["conexion_mysql"].ConnectionString;

        }

        public MySqlConnection ConectarMysql() //Metoto para conectar a C# a MySQL
        {
            string CadenaConexion;
            CadenaConexion = cad_Conexion();
            MySqlConnection Conexion = new MySqlConnection(CadenaConexion);
            try
            {
                Conexion.Open();
            }
            catch (Exception error)
            {
                //   MessageBox.Show("Error de configuración del sistema " + error.Message, "Aplicación : ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //   Application.Exit();
            }
            return Conexion;
        }


        public DataSet EjecutarSelectMysql(string p)
        {
            System.Data.DataSet dt = new System.Data.DataSet();

            MySqlConnection Conn = ConectarMysql();
            MySqlCommand ComandoSelect = new MySqlCommand(p);
            ComandoSelect.Connection = Conn;

            // MySqlDataReader Resultado;
            MySqlDataAdapter da = new MySqlDataAdapter(p, Conn);
            //da = ComandoSelect.ExecuteReader();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
    }
}
