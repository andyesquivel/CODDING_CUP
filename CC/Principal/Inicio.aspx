<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Inicio.aspx.cs" Inherits="Inicio" %>

<!DOCTYPE html>


<html lang="es">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
        <link rel="stylesheet" href="css/estilos.css" />
    </asp:PlaceHolder>
    <webopt:BundleReference runat="server" Path="~/Content/css" />

</head>
<body>
    <form runat="server">
        <asp:ScriptManager runat="server">
            <Scripts>
                <%--Para obtener más información sobre la unión de scripts en ScriptManager, consulte https://go.microsoft.com/fwlink/?LinkID=301884 --%>
                <%--Scripts de marco--%>
                <asp:ScriptReference Name="MsAjaxBundle" />
                <asp:ScriptReference Name="jquery" />
                <asp:ScriptReference Name="bootstrap" />
                <asp:ScriptReference Name="respond" />
                <asp:ScriptReference Name="WebForms.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebForms.js" />
                <asp:ScriptReference Name="WebUIValidation.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebUIValidation.js" />
                <asp:ScriptReference Name="MenuStandards.js" Assembly="System.Web" Path="~/Scripts/WebForms/MenuStandards.js" />
                <asp:ScriptReference Name="GridView.js" Assembly="System.Web" Path="~/Scripts/WebForms/GridView.js" />
                <asp:ScriptReference Name="DetailsView.js" Assembly="System.Web" Path="~/Scripts/WebForms/DetailsView.js" />
                <asp:ScriptReference Name="TreeView.js" Assembly="System.Web" Path="~/Scripts/WebForms/TreeView.js" />
                <asp:ScriptReference Name="WebParts.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebParts.js" />
                <asp:ScriptReference Name="Focus.js" Assembly="System.Web" Path="~/Scripts/WebForms/Focus.js" />
                <asp:ScriptReference Name="WebFormsBundle" />
                <%--Scripts del sitio--%>
            </Scripts>
        </asp:ScriptManager>

        <!-- Navbar-->

        <div>
            <div class="navbar navbar-light navbar-fixed-top" style="background-color: #E0E6ED;" role="navigation">
                <div class="container">
                    <div class="navbar-header">
                        <button id="nav-toggle-button" type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                            <span class="sr-only">Toggle navigation</span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                        </button>
                        <a class="navbar-brand" style="margin: 0; padding-top: 0; float: none; position: absolute; left: 32%;" href="Inicio.aspx">
                            <img id="navbar-logo" alt="Logo" src="img/logo.png" height="52" width="380" />
                        </a>
                    </div>
                    <div class="navbar-collapse collapse">
                        <ul class="nav navbar-nav navbar-right">
                            <li><a class="navbar-brand" href="#"><span class="glyphicon glyphicon-user"></span> Obtener cuenta</a></li>
                            <li class="dropdown">
                                <a href="#" class="navbar-brand" data-toggle="dropdown"><span class="glyphicon glyphicon-log-in"></span> Login<b class="caret"></b></a>
                                <ul class="dropdown-menu">
                                    <li class="dropdown-header">Iniciar sesión como</li>
                                    <li role="separator" class="divider"></li>
                                    <li><a href="#">Contacto</a></li>
                                    <li><a href="#">Administrador</a></li>
                                </ul>
                            </li>

                        </ul>
                    </div>
                </div>

            </div>

            <!-- Navbar-->

            <!-- Carrusel inicio-->

            <div class="row">
                <div class="col-md-8">
                    <div id="myCarousel" class="carousel slide" data-ride="carousel">
                        <!-- Indicators -->
                        <ol class="carousel-indicators">
                            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                            <li data-target="#myCarousel" data-slide-to="1"></li>
                            <li data-target="#myCarousel" data-slide-to="2"></li>
                        </ol>

                        <!-- Wrapper for slides -->
                        <div class="carousel-inner">
                            <div class="item active">
                                <img src="img/Inicio1.jpg" alt="Inicio1">
                            </div>

                            <div class="item">
                                <img src="img/Inicio2.jpg" alt="Inicio2">
                            </div>

                            <div class="item">
                                <img src="img/Inicio3.jpg" alt="Inicio3">
                            </div>
                        </div>

                        <!-- Left and right controls -->
                        <a class="left carousel-control" href="#myCarousel" data-slide="prev">
                            <span class="glyphicon glyphicon-chevron-left"></span>
                            <span class="sr-only">Previous</span>
                        </a>
                        <a class="right carousel-control" href="#myCarousel" data-slide="next">
                            <span class="glyphicon glyphicon-chevron-right"></span>
                            <span class="sr-only">Next</span>
                        </a>
                    </div>
                    <!-- Carrusel inicio-->
                </div>

                <div>
                    <div class="col-lg-2">
                        <a style="margin: 25px; padding-top: 0; float: none; position: absolute;">
                            <img id="Not1" alt="Not1" src="img/Not1.jpg" height="150" width="200" />
                        </a>
                    </div>
                    <div class="col-md-2">
                        <div class="container">
                            <div class="panel panel-primary">
                                <div class="panel-heading">Coding cup 2018</div>
                                <div class="panel-body">
                                    Concurso de programacion estatal Coding Cup 2018
                                <div>
                                    <a>Ver más</a>
                                </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div>
                    <div class="col-lg-2">
                        <a style="margin-left:25px; padding-top: 27px; float: none; position: absolute;">
                            <img id="Not2" alt="Not2" src="img/Not2.jpg" height="150" width="200" />
                        </a>
                    </div>
                    <div class="col-md-2">
                        <div class="container">
                            <div class="panel panel-primary">
                                <div class="panel-heading">Coding cup 2017</div>
                                <div class="panel-body">
                                    Concurso de programacion estatal Coding Cup 2017
                                <div>
                                    <a>Ver más</a>
                                </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>


                <div>
                    <div class="col-lg-2">
                        <a style="margin-left:25px; padding-top: 27px; float: none; position: absolute;">
                            <img id="Not3" alt="Not3" src="img/Not3.jpg" height="150" width="200" />
                        </a>
                    </div>
                    <div class="col-md-2">
                        <div class="container">
                            <div class="panel panel-primary">
                                <div class="panel-heading">Coding cup 2016</div>
                                <div class="panel-body">
                                    Concurso de programacion estatal Coding Cup 2016
                                <div>
                                    <a>Ver más</a>
                                </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div>
                    </div>
                </div>

            </div>

            
        </div>
    </form>
</body>
</html>
