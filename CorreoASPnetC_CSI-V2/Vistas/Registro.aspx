<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="CorreoaspC_CSI.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <title>Registro de Usuario</title>
      <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script> 

        <link href="/Css/estilos_1.css" rel="stylesheet" />
        <script>
            function nobackbutton() {
                window.location.hash = "no-back-button";
                window.location.hash = "Again-No-back-button" //chrome
                window.onhashchange = function () {
                    window.location.hash = "no-back-button";
                }
            }

        </script>

</head>
<body background= "../Css/FondoRegistro.jpg" onload="nobackbutton()">
     <center>
    <form id="form1" runat="server">
    <div>
     <div>
                <h1 class="bg-primary">Datos Personales</h1>   
                <table border="0" width="10" class="table" style="width:40%" cellspacing="1">
                    <thead>
                         <tr>
                            <th>IDENTIFICACION</th>
                            <td><asp:TextBox ID="TextIdentificacion" runat="server" size="60"></asp:TextBox></td>

                        </tr>
                    </thead> 
                    <tbody>
                       
                        <tr>
                            <th>NOMBRES</th>
                            <td><asp:TextBox ID="TextNombres" runat="server" size="60" ></asp:TextBox></td>

                        </tr>
                        <tr>
                            <th>APELLIDOS</th>
                            <td><asp:TextBox ID="TextApellidos" runat="server" size="60"></asp:TextBox></td>

                        </tr>

                        <tr>
                            <th>NOMBRE USUARIO</th>
                            <td><asp:TextBox ID="TextNombreUsuario" runat="server" size="60"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <th>Contraseña</th>
                            <td><asp:TextBox ID="TextContra1" runat="server" type="Password" placeholder="&#128272; Contraseña"   size="60"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <th>Vuelva a repetirla</th>
                            <td> <asp:TextBox ID="TextContra2" runat="server" type="Password" placeholder="&#128272; Contraseña" size="60"></asp:TextBox></td>
                        </tr>
                    </tbody>
                </table>
            </div>
          <asp:Button ID="Volver" runat="server" Text="Volver" class="btn btn-danger" OnClick="Volver_Click" ></asp:Button>
        &nbsp;&nbsp;<asp:Button ID="RegistarPersona" runat="server" Text="Registrar" class="btn btn-primary" OnClick="RegistarPersona_Click"></asp:Button>
      




    </div>
    </form>
</body></center>
</html>
