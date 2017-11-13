using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Conexion;
using CorreoASPnetC_CSI_V2.Interfaces;
namespace LogicaModelo
{
    public class MensajeEnvi:IMensaje
    {
        public string Destinatario;
        public string Remitente;
        public string Cuerpo;

        public MensajeEnvi()
        {

        }
     

    
        public bool EnviarMensaje()
        {
            List<MySqlParameter> lista = new List<MySqlParameter>();
            string sql = "insert into mensaje(remitente,destinatario,cuerpo) values('" + this.Remitente + "','" + this.Destinatario+"','"+this.Cuerpo+"')";

            bool c = Conexion.Conexion.EjecutarOperacion(sql, lista, System.Data.CommandType.Text);
            return c;
        }

        public DataTable consultarBandeja(string Destinatario)
        {

            List<MySqlParameter> lista = new List<MySqlParameter>();
            string sql = "Select remitente,cuerpo from Mensaje where destinatario = '" + this.Destinatario + "'";
            DataTable c = Conexion.Conexion.EjecutarConsulta(sql, lista, System.Data.CommandType.Text);
            return c;
        }

        public DataTable consultarEnviados(string Remitente)
        {

            List<MySqlParameter> lista = new List<MySqlParameter>();
            string sql = "Select destinatario,cuerpo from Mensaje where remitente = '" + this.Remitente + "'";
            DataTable c = Conexion.Conexion.EjecutarConsulta(sql, lista, System.Data.CommandType.Text);
            return c;
        }
        public List<DataRow> buscarBandeja(string Destinatario)
        {
            List<MySqlParameter> lista = new List<MySqlParameter>();
            List<DataRow> litp = new List<DataRow>();
            string sql = "SELECT remitente,cuerpo FROM mensaje WHERE destinatario= '" + this.Destinatario + "')";
            litp = Conexion.Conexion.EjecutarConsulta(sql, lista, System.Data.CommandType.Text).Rows.Cast<DataRow>().ToList();
            return litp;
        }

    }
     
}
