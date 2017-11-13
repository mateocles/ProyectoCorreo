using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicaModelo;
using CorreoASPnetC_CSI_V2.Interfaces;
using System.Data;

namespace CorreoaspC_CSI
{
    public partial class Login : System.Web.UI.Page
    {
        Persona pers = new Persona();
        IPersona IPers;
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Remove("Persona");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            pers.NombreUsuario= TextNombreUsuario.Text;
            pers.ContrasenaUsuario = TextContrasena.Text;
            //Session["NombreUsuario"] = pers.NombreUsuario;
            IPers = pers;
           
            DataTable dt = IPers.Consultar_Persona(pers);
            if (dt.Rows.Count > 0)
            {
                //DataRow fila = dt.Rows[0];
                //Session["Cedula"] = fila["Cedula"].ToString();
                //Session["Estado"] = "T";
                Response.Redirect("Menu.aspx");
            }
            else
            {
                Response.Write("<script language=javascript>alert('El NombreUsuario no concuerda con la Contraseña');</script>");

            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro.aspx");
        }
    }
}