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
    public partial class MensajesEnviados : System.Web.UI.Page
    {
        MensajeEnvi Mens = new MensajeEnvi();
        IMensaje IMens;
        Persona pers = new Persona();
        IPersona IPers;
        protected void Page_Load(object sender, EventArgs e)
        {

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

            Mens.Remitente = TextIdRemitente.Text;
            IMens = Mens;
            GridView1.DataSource = IMens.consultarEnviados(Mens.Remitente);
            GridView1.DataBind();

        }
    }
    }
