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
    public partial class Mensaje : System.Web.UI.Page
    {
        MensajeEnvi Mens = new MensajeEnvi();
        IMensaje IMens;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Persona pers = new Persona();
            //IPersona IPers;
            //pers.NombreUsuario = Session["NombreUsuario"].ToString();
            //IPers = pers;
            //DataTable x = IPers.Consultar_NombreUsuario(pers.NombreUsuario);
            //LabelIdRemitente.Text = x.Rows[0]["Cedula"].ToString();
            //Label1Nombre.Text = x.Rows[0]["Nombre"].ToString();
           
        }

        protected void BuscarPersona_Click(object sender, EventArgs e)
        {
            if (TextIdDestinatario.Text != "")
            {
                try
                {
                    Persona pers = new Persona();
                    IPersona IPers;
                    pers.Cedula = TextIdDestinatario.Text;
                    IPers = pers;

                    DataTable t = IPers.Consultarid(pers.Cedula);

                    LabelNombreDestini.Text = t.Rows[0]["Nombre"].ToString();
                
                }
                catch (Exception)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Ese Usuario no Existe')", true);


                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Complete los campos')", true);

            }

        }

        protected void EnviarMensaje_Click(object sender, EventArgs e)
        {
            if (TextIdDestinatario.Text != "" && Mensajecuerpo.ToString() != ""&& TextIdRemitente.Text!="")
            {
                Mens.Destinatario = TextIdDestinatario.Text;
                Mens.Remitente = TextIdRemitente.Text;
                Mens.Cuerpo = Mensajecuerpo.Value;
                IMens = Mens;
               if ( IMens.EnviarMensaje()!= false)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se a Enviado el mensaje')", true);
                    TextIdDestinatario.Text = "";
                    TextIdRemitente.Text = "";
                    Mensajecuerpo.Value = "";
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('No se Envio el mensaje')", true);

                }



            }
            else
            {

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Complete los campos')", true);

            }
        }

        protected void MensajesEnviados_Click(object sender, EventArgs e)
        {
            Response.Redirect("MensajesEnviados.aspx");
        }

        protected void Bandeja_Click(object sender, EventArgs e)
        {
            Response.Redirect("Bandeja.aspx");
        }

        protected void Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }

        protected void BuscarPersonaRe_Click(object sender, EventArgs e)
        {
             if (TextIdRemitente.Text != "")
            {
                try
                {
                    Persona pers = new Persona();
                    IPersona IPers;
                    pers.Cedula = TextIdRemitente.Text;
                    IPers = pers;

                    DataTable t = IPers.Consultarid(pers.Cedula);

                   LabelRemitente.Text = t.Rows[0]["Nombre"].ToString();
                
                }
                catch (Exception)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Ese Usuario no Existe')", true);


                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Complete los campos')", true);

            }
        }
    }
}
