<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="CorreoASPnetC_CSI_V2.Vistas.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script> 
        <style>
            .whitetext {
                color: white;
            }
        </style>

    <title>Menu</title>
</head>
<body background= "/Css/2.jpg">
    <form id="form1" runat="server">
    <center>   <h1 class="bg-primary" class="whitetext">Menu</h1></center>
       
    
            <center>
                 <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
          <br>
            <a href="DatosPersonales.aspx"> <img src="/Css/imageusu.png" width="250" height="250"> </a>
             <br>
         <label>Ingresar un Usuario</label>
     
     
           <br>
            <a href="Mensaje.aspx"> <img src="../Css/MetroUI_Mail.png" width="250" height="250"> </a>
         <br>
          <label>Enviar un Correo</label>
    </center>
          &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="Cerrar Sesion" class="btn btn-danger" OnClick="Button1_Click"/>  

    </form>
     </body>
</html>
