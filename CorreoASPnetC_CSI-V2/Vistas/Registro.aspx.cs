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
    public partial class Registro : System.Web.UI.Page
    {
        Persona pers = new Persona();
        IPersona IPers;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegistarPersona_Click(object sender, EventArgs e)
        {
            if (TextIdentificacion.Text !="" && TextNombres.Text !="" && TextApellidos.Text!=""&& TextNombreUsuario.Text!="" && TextContra1.Text!=""&& TextContra2.Text!=""   )
            {
                if (TextContra1.Text == TextContra2.Text)
                {


                    pers.Cedula = TextIdentificacion.Text;
                    pers.Nombre = TextNombres.Text;
                    pers.Apellido = TextApellidos.Text;
                    pers.NombreUsuario = TextNombreUsuario.Text;
                    pers.ContrasenaUsuario = TextContra1.Text;
                    IPers = pers;
                    DataTable dt = IPers.Consultar_NombreUsuario(TextNombreUsuario.Text);
                    if (dt.Rows.Count == 0)
                    {

                        if (IPers.Agregar_persona(TextIdentificacion.Text, TextNombres.Text, TextApellidos.Text, TextNombreUsuario.Text, TextContra1.Text) == false)
                        {
                            Response.Write("<script language=javascript>alert('El numero ID ya existe');</script>");
                        }
                        else
                        {
                            Response.Write("<script language=javascript>alert('El registro fue Exitoso');</script>");
                            TextIdentificacion.Text = "";
                            TextNombres.Text = "";
                            TextApellidos.Text = "";
                            TextNombreUsuario.Text = "";
                            TextContra1.Text = "";
                            TextContra2.Text = "";
                        }
                    }else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Ese Nombre Usuario ya Existe')", true);

                    }

                }
                    else
                    {
                        Response.Write("<script language=javascript>alert('Las contraseñas no concuerdan!!');</script>");


                    }
                
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Por favor llene todos los campos')", true);

            }
        }

        protected void Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}