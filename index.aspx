<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <!-- Bootstrap -->
    <link href="css/bootstrap.min.css" rel="stylesheet"/>
    <!-- styles -->
    <link href="css/styles.css" rel="stylesheet"/>
</head>
<body class="login-bg">
<form id="form1" runat="server">
  	<%--<div class="header">
	     <div class="container">
	        <div class="row">
	           <div class="col-md-12">
	              <!-- Logo -->
	              <div class="logo">
	                 <h1><a>Demo</a></h1>
	              </div>
	           </div>
	        </div>
	     </div>
	</div>--%>
    <div class="page-content container">
		<div class="row">
			<div class="col-md-4 col-md-offset-4">
				<div class="login-wrapper">
			        <div class="box">
			            <div class="content-wrap">
	                            <h6>Sign In</h6>
        <asp:TextBox ID="txtUser" runat="server" CssClass="form-control" placeholder='User Id'></asp:TextBox>
        <asp:TextBox ID="txtPwd" runat="server" CssClass="form-control" placeholder="Password" TextMode="Password"></asp:TextBox>
                        <div class="action">
        <asp:Button ID="Button1" OnClick="Button1_Click" CssClass="btn btn-primary signup" runat="server" Text="Login" />
                            </div>
	</div>
			        </div>

			        <div class="already">
                        <p> Forgot Password ?</p>
                        <a href="Forgot.aspx" target="_blank">Forgot Password.</a><br />
                        <p>Don't have an account yet?</p>
			            <a href="Register.aspx" target="_blank">Sign Up</a>
			        </div>
			    </div>
			</div>
		</div>
	</div>


    </form>
    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="https://code.jquery.com/jquery.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>
    <script src="js/custom.js"></script>
</body>
</html>
