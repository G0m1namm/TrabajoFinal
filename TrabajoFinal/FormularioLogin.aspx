<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormularioLogin.aspx.cs" Inherits="TrabajoFinal.FormularioLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0, minimum-scale=1.0, maximum-scale=1.0, user-scalable=no">

    <title>Iniciar sesión</title>

        <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />

    <!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" />
    <!--===============================================================================================-->
	<link rel="icon" type="image/png" href="images/icons/favicon.ico"/>

    <link href="css/Forms.css" rel="stylesheet" />
    <link href="css/main.css" rel="stylesheet" />
    <link href="css/util.css" rel="stylesheet" />

    <!-- Latest compiled and minified JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" ></script>


</head>
<body>
  
   
     <form id="FormularioLogin" runat="server">
         <h1>Login</h1>
         <div class="container">
                  
            <div class="wrapper">
                
                <div class="form-group f1">
                        <asp:Label ID="Etiqueta1" runat="server" Text="ID usuario: "></asp:Label>
                        <asp:TextBox ID="CampoID" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvID" runat="server" ErrorMessage="Campo necesario!" ForeColor="Red" ControlToValidate="CampoID" ValidationGroup="Admin"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group f1">
                        <asp:Label ID="Etiqueta2" runat="server" Text="Contraseña: "></asp:Label>
                        <asp:TextBox ID="CampoPassword" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="Campo necesario!" ForeColor="Red" ControlToValidate="CampoPassword" ValidationGroup="Admin"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group f1">
                        <asp:Button ID="BotonValidar" runat="server" Text="Iniciar sesión" CssClass="btn btn-primary btn-2" OnClick="BotonValidar_Click"/>
                        <asp:Button ID="BotonLimpiar" runat="server" Text="Limpiar" CssClass="btn btn-danger btn-2" OnClick="BotonLimpiar_Click"/>
                </div>

            </div>
                        
            <div class="wrapper2">
                 <div class="form-group">
                        <asp:Button ID="BotonArticulo" runat="server" Text="Ver artículos disponibles" CssClass="btn btn-danger btn-2" OnClick="BotonArticulo_Click"/>
                        <asp:Button ID="BotonHistorial" runat="server" Text="Ver historial de compra" CssClass="btn btn-danger btn-2" OnClick="BotonHistorial_Click"/>
                        <asp:Button ID="BotonComportamiento" runat="server" Text="Ver comportamiento de usuarios" CssClass="btn btn-danger btn-2" OnClick="BotonComportamiento_Click"/> 
                </div>

                <div class="form-group">
                        <asp:Label ID="EtiquetaConfirmacion" runat="server"></asp:Label>
                </div>
            </div>
               
        </div>

    </form>
           
    <!--===============================================================================================-->
	<script src="vendor/jquery/jquery-3.2.1.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/animsition/js/animsition.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/bootstrap/js/popper.js"></script>
	<script src="vendor/bootstrap/js/bootstrap.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/select2/select2.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/daterangepicker/moment.min.js"></script>
	<script src="vendor/daterangepicker/daterangepicker.js"></script>
<!--===============================================================================================-->
	<script src="vendor/countdowntime/countdowntime.js"></script>
<!--===============================================================================================-->
	<script src="js/main.js"></script>
    
</body>

</html>
