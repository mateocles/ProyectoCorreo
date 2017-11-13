using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using CorreoASPnetC_CSI_V2.Interfaces;
using Conexion;
namespace LogicaModelo
{
  public class Persona :IPersona
    {

        public string Nombre;
        public string Apellido;
        public string Cedula;
        public string NombreUsuario;
        public string ContrasenaUsuario;

        public Persona()
        {

        }
  
       
        public bool Agregar_persona(string Cedulo,string Nombre,string Apellido, string NombreUsuario,string ContraseñaUsuario) 
        {
            List<MySqlParameter> lista = new List<MySqlParameter>();
            string sql = "insert into persona(Cedula,Nombre,Apellido,NombreUsuario,ContrasenaUsuario) values('" + Cedula + "','" + Nombre+ "','" + Apellido + "','" + NombreUsuario + "',md5('" + ContrasenaUsuario + "'))";
         
            bool c = Conexion.Conexion.EjecutarOperacion(sql, lista, System.Data.CommandType.Text);
            return c;
        }

        public DataTable Consultar_Persona(Persona objeto)
        {
           
            List<MySqlParameter> lista = new List<MySqlParameter>();
            string sql = "select Cedula,Nombre, Apellido from persona where NombreUsuario='" + objeto.NombreUsuario + "' and ContrasenaUsuario=md5('" + objeto.ContrasenaUsuario + "')";
            DataTable c = Conexion.Conexion.EjecutarConsulta(sql, lista, System.Data.CommandType.Text);
            return c;
        }
        public DataTable Consultar_NombreUsuario(string NombreUsuario)
        {
            
           
            List<MySqlParameter> lista = new List<MySqlParameter>();
            string sql = "select Cedula,Nombre, Apellido from persona where NombreUsuario='" + this.NombreUsuario + "'";
            DataTable c = Conexion.Conexion.EjecutarConsulta(sql, lista, System.Data.CommandType.Text);
            return c;
        
        }

        public bool Editar_Persona(string Cedula,string Nombre,string Apellido)
        {
            List<MySqlParameter> lista = new List<MySqlParameter>();
            string sql = "UPDATE persona SET Nombre='"+this.Nombre+"', Apellido='"+this.Apellido+"' WHERE Cedula='"+this.Cedula+"'";
            bool c = Conexion.Conexion.EjecutarOperacion(sql, lista, System.Data.CommandType.Text);
            return c;
        }
        public DataTable Consultarid(string Cedula)
        {
            List<MySqlParameter> lista = new List<MySqlParameter>();
            String sql="Select Nombre,Apellido,NombreUsuario from Persona where Cedula ='"+this.Cedula+"'";
            DataTable c = Conexion.Conexion.EjecutarConsulta(sql,lista,System.Data.CommandType.Text);
            return c;
        }

    }
  
}
