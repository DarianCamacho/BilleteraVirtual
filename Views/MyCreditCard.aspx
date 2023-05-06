<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyCreditCard.aspx.cs" Inherits="BilleteraVirtual.Views.MyCreditCard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.1/jquery.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"
    integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
    <link rel="stylesheet"
    id="theme_link"
    href="https://cdnjs.cloudflare.com/ajax/libs/bootswatch/5.1.2/lux/bootstrap.min.css" />
    <link rel="stylesheet" type="text/css" href="StyleInicio.css"/>
    <title>My Credit Card</title>
</head>

<body>
    <form id="form1" runat="server">

            <%--OFFCANVA--%>
       
            <nav class="navbar navbar-expand-lg navbar-dark bg-primary">
                <div class="container-fluid">
                    <a class="navbar-brand" href="#">Billetera Virtual</a>
                    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarColor01" aria-controls="navbarColor01" aria-expanded="false" aria-label="Toggle navigation">
                        <span class="navbar-toggler-icon"></span>
                    </button>
                    <div class="collapse navbar-collapse" id="navbarColor01">
                        <ul class="navbar-nav me-auto">
                            <li class="nav-item">
                                <a class="nav-link active" href="Inicio.aspx">Home
                                 <span class="visually-hidden">(current)</span>
                                </a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="#">Features</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="#">About</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>

        <%--OFFCANVA--%>

        <!-- Utilizar un Repeater para generar múltiples Cards -->

        <div class="row">
            <asp:Repeater ID="repTarjeta" runat="server">
                <ItemTemplate>
                    <div class="col-md-4 mb-4">
                        <div class="card credit-card">
                            <div class="card-header">
                                <img src='<%#Eval("Foto") %>' class="card-img-top img-thumbnail" alt="...">
                            </div>
                            <div class="card-body">
                                <h5 class="card-title"><%# Eval("Banco") %></h5>
                                <p class="card-text"><%# Eval("Emisor") %></p>
                                <p class="card-text"><%# Eval("Dueno") %></p>
                                <hr />
                                <div class="row">
                                    <div class="col-7">
                                        <small class="text-muted">NÚMERO DE TARJETA</small>
                                        <h6 class="card-text"><%# Eval("NumeroTarjeta") %></h6>
                                    </div>
                                    <div class="col-5 text-right">
                                        <small class="text-muted">CVV</small>
                                        <h6 class="card-text"><%# Eval("CodigoCVV") %></h6>
                                    </div>
                                </div>
                                <hr />
                                <p class="card-text"><small class="text-muted">VENCIMIENTO</small></p>
                                <p class="card-text"><%# Eval("FechaExpiracion") %></p>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        
        <!-- Utilizar un Repeater para generar múltiples Cards -->

    </form>
</body>
</html>
