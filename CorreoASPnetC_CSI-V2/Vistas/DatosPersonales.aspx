<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DatosPersonales.aspx.cs" Inherits="CorreoASPnetC_CSI_V2.Vistas.DatosPersonales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script> 
        <link href="/Css/estilos_1_1.css" rel="stylesheet" />
   <title>Persona</title>
</head>
<body background= "Css/2.jpg"> <center>
     <h1 class="bg-primary">Datos Personales</h1>
    <form id="form1" runat="server">
    <div>
                <img src="/Css/usu.png" width="100" height="100" alt=""/>

                <table border="0" width="10" class="table" style="width:40%" cellspacing="1">
                    <thead>
                        <tr>
                            <th>IDENTIFICACION</th>
                            <td><asp:TextBox ID="textIdentificacion" runat="server"   size="60"></asp:TextBox></td>

                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <th>NOMBRES</th>
                            <td><asp:TextBox ID="TextNombre" runat="server" size="60"></asp:TextBox> </td>

                        </tr>
                        <tr>
                            <th>APELLIDOS</th>
                            <td><asp:TextBox ID="TextApellido" runat="server"  size="60"></asp:TextBox></td>

                        </tr>

                        <tr>
                            <th>NOMBRE USUARIO</th>
                            <td><asp:TextBox ID="TextNombreUsua" runat="server" size="60"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <th>Contraseña</th>
                            <td><asp:TextBox ID="TextContrasena1" type="Password"  placeholder="&#128272; Contraseña" size="60"  runat="server"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <th>Vuelva a repetirla</th>
                            <td><asp:TextBox ID="TextContrasena2" type="Password"  size="60" placeholder="&#128272; Contraseña"  runat="server"></asp:TextBox></td>
                        </tr>
                    </tbody>
                </table>
            </div>
<asp:Button ID="GuardarPersona" runat="server" Text="Guardar Perso" class="btn btn-primary" OnClick="GuardarPersona_Click"></asp:Button>
<asp:Button ID="BuscarPersona" runat="server" Text="Buscar Perso" class="btn btn-primary" OnClick="BuscarPersona_Click"></asp:Button>
<asp:Button ID="ModificarPersona" runat="server" Text="Modificar Perso" class="btn btn-primary" OnClick="ModificarPersona_Click"></asp:Button>
    <br>       
     <br>
    <br>
<asp:Button ID="Button1" runat="server" Text="Enviar Mensaje"  class="btn btn-primary" OnClick="Button1_Click"></asp:Button>
<asp:Button ID="Button2" runat="server" Text="Volver"  class="btn btn-primary" OnClick="Button2_Click"></asp:Button>
    </form>
    <br>
   
</body></center>
</html>
