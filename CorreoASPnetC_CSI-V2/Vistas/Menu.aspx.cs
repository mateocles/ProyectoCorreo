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
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    //Persona pers = new Persona();
            //    //IPersona IPers;
            //    //pers.NombreUsuario = Session["NombreUsuario"].ToString();
            //    //IPers = pers;
            //    //DataTable x = IPers.Consultar_NombreUsuario(pers.NombreUsuario);
            //    //Label1.Text = x.Rows[0]["Nombre"].ToString();
            //    //Label2.Text = x.Rows[0]["Apellido"].ToString();



            //}
            //catch (Exception)
            //{
            //    Response.Redirect("Login.aspx");
            //}
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

            Response.Redirect("DatosPersonales.aspx");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Session["Estado"] = "F";
            Response.Redirect("Login.aspx");
        }
    }
}