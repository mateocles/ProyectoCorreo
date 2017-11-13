using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicaModelo;
using CorreoASPnetC_CSI_V2.Interfaces;
using System.Data;
namespace CorreoASPnetC_CSI_V2.Vistas
{
    public partial class Bandeja : System.Web.UI.Page
    {
        MensajeEnvi Mens = new MensajeEnvi();
        IMensaje IMens;
        Persona pers = new Persona();
        IPersona IPers;
        protected void Page_Load(object sender, EventArgs e)
        {
            //MensajeEnvi Mens = new MensajeEnvi();
            //IMensaje IMens;
            //Persona pers = new Persona();
            //IPersona IPers;
            //pers.NombreUsuario = Session["NombreUsuario"].ToString();
            //IPers = pers;
            //DataTable x = IPers.Consultar_NombreUsuario(pers.NombreUsuario);
            //LabelIdenti.Text = x.Rows[0]["Cedula"].ToString();
            //LabelNombre.Text = x.Rows[0]["Nombre"].ToString();

            //Mens.Destinatario = LabelIdenti.Text;
            //IMens = Mens;
            //DataTable b= IMens.consultarBandeja(Mens.Destinatario);

            //TextAreaMensaCuerpo.Value = b.Rows[0]["cuerpo"].ToString();

        }

        protected void BuscarPersonaRe_Click(object sender, EventArgs e)
        {
            try
            {
                pers.Cedula = TextIdRemitente.Text;
                IPers = pers;
                DataTable db = IPers.Consultarid(pers.Cedula);

                LabelRemitente.Text = db.Rows[0]["Nombre"].ToString();
            }
            catch (Exception)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('No se encontro el Usuario')", true);

            }

            Mens.Destinatario = TextIdRemitente.Text;
            IMens = Mens;
            GridView1.DataSource = IMens.consultarBandeja(Mens.Destinatario);
            GridView1.DataBind();

        }
    }
}