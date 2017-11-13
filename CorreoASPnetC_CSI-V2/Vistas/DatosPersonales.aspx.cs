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
    public partial class DatosPersonales : System.Web.UI.Page
    {
        Persona pers = new Persona();
        IPersona IPers;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GuardarPersona_Click(object sender, EventArgs e)
        {

            if ( textIdentificacion.Text != "" &&  TextNombre.Text != "" && TextApellido.Text != "" && TextNombreUsua.Text != "" && TextContrasena1.Text != "" && TextContrasena2.Text != "")
            {
                if (TextContrasena2.Text == TextContrasena1.Text)
                {


                    pers.Cedula = textIdentificacion.Text;
                    pers.Nombre = TextNombre.Text;
                    pers.Apellido = TextApellido.Text;
                    pers.NombreUsuario = TextNombreUsua.Text;
                    pers.ContrasenaUsuario = TextContrasena1.Text;
                    IPers = pers;
                    DataTable dt = IPers.Consultar_NombreUsuario(TextNombreUsua.Text);
                    if (dt.Rows.Count == 0)
                    {
                        if (IPers.Agregar_persona(textIdentificacion.Text, TextNombre.Text, TextApellido.Text, TextNombreUsua.Text, TextContrasena1.Text) == false)
                        {
                            Response.Write("<script language=javascript>alert('El numero ID ya existe');</script>");
                        }
                        else
                        {
                            Response.Write("<script language=javascript>alert('El registro fue Exitoso');</script>");
                            textIdentificacion.Text = "";
                            TextNombre.Text = "";
                            TextApellido.Text = "";
                            TextNombreUsua.Text = "";
                            TextContrasena1.Text = "";
                            TextContrasena2.Text = "";
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



    protected void BuscarPersona_Click(object sender, EventArgs e)
        {

            try
            {

                pers.Cedula = textIdentificacion.Text;
                IPers = pers;
                DataTable db = IPers.Consultarid(pers.Cedula);

                TextNombre.Text = db.Rows[0]["Nombre"].ToString();
                TextApellido.Text = db.Rows[0]["Apellido"].ToString();
                TextNombreUsua.Text = db.Rows[0]["NombreUsuario"].ToString();
            }
            catch (Exception)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Ese Usuario no Existe')", true);

            }




        }

        protected void ModificarPersona_Click(object sender, EventArgs e)
        {

            if (textIdentificacion.Text != "" && TextNombre.Text != "" && TextApellido.Text != "")
            {

                pers.Cedula = textIdentificacion.Text;
                pers.Nombre = TextNombre.Text;
                pers.Apellido = TextApellido.Text;
                IPers = pers;
               if( IPers.Editar_Persona(pers.Cedula, pers.Nombre, pers.Apellido) != false)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Sea Modificacado con exito')", true);

                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Ese Usuario no Existe')", true);

                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Llene todos los campos para modificar la persona')", true);

            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Mensaje.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }
    }
}