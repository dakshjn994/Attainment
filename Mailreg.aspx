<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Mailreg.aspx.cs" Inherits="Mailreg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mail Registration</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <!-- Bootstrap -->
    <link href="css/bootstrap.min.css" rel="stylesheet"/>
    <!-- styles -->
    <link href="css/styles.css" rel="stylesheet"/>

</head>
<body class="login-bg" aria-autocomplete="none">
    <form id="form1" runat="server">
    <div class="page-content container">
		<div class="row">
			<div class="col-md-4 col-md-offset-4">
				<div class="login-wrapper">
			        <div class="box">
			            <div class="content-wrap">
			                <h6>Sign Up</h6>
			                <input class="form-control" id="name" runat="server" type="text" placeholder="Full Name"/>
                            <input class="form-control" id="pwd" runat="server" type="password" placeholder="Password"/>
                            <input class="form-control" id="rpwd" runat="server" type="password" placeholder="Re-Enter Password"/>
			                <div class="action">
			                    <a class="btn btn-primary signup" runat="server" id="email" onserverclick="email_ServerClick">Sign Up</a>
			                </div>                
			            </div>
			        </div>

			        <div class="already">
			            <p>Have an account already?</p>
			            <a href="index.aspx">Login</a>
			        </div>
			    </div>
			</div>
		</div>
	</div>
    </form>
    <script src="js/Mine.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>
    <script src="js/custom.js"></script>
</body>
</html>
