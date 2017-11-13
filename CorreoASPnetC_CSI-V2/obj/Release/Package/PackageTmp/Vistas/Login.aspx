<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CorreoaspC_CSI.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script> 
     
        <link href="/Css/estilos.css" rel="stylesheet" />
        <style>
            .whitetext {
                color: white;
            }
        </style>
        <script>
            function nobackbutton() {
                window.location.hash = "no-back-button";
                window.location.hash = "Again-No-back-button" //chrome
                window.onhashchange = function () {
                    window.location.hash = "no-back-button";
                }
            }

        </script>
    <title>Login</title>
</head>
<body background= "../Css/2.jpg" onload="nobackbutton()">
    <form id="form1"   runat="server">
    <div>
    
         <h2 > Iniciar Sesión </h2>
            <table class="table" style="width:40%" border="0">
                <thead>
                    <tr>
                        <th>Usuario</th>
                        <td><asp:TextBox ID="TextNombreUsuario" runat="server" type="text" placeholder="&#128272; Nombre Usuario"  size="40"></asp:TextBox></td>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <th>Contraseña</th>
                        <td>
                            <asp:TextBox ID="TextContrasena" type="password" placeholder="&#128272; Contraseña" runat="server" size="40" ></asp:TextBox></td>
                    </tr>
                    

                </tbody>
            </table>
                   <br>

        <asp:Button class="btn btn-success" ID="Button1"  runat="server" Text="Ingresar" OnClick="Button1_Click" />
            &nbsp;&nbsp; <asp:Button ID="Button3" class="btn btn-primary"  runat="server" Text="Registrarse" OnClick="Button3_Click" />
      
        




    </div>
    </form> </center>
</body>
</html>
