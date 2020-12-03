<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TheGildedRoseOnlineStore._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>The Gilded Rose Online Store</h1>
        <p class="lead">The Gilded Rose is small boutique inn on the outskirts of a prominent city that buys and sells items of the finest quality. 
            We are now open as an online store that allows people from afar to purchase our wares.</p>
        <p><a href="About.aspx" class="btn btn-primary btn-lg">Shop with us &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-6">
            <h2>Our online shop</h2>
            <p>
                Now you can select any item and purchase immediately at Gilded Rose Online Store. 
                See our exclusive collection at the product page
            </p>
            <p>
                <a class="btn btn-default" href="About.aspx">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-6">
            <h2>How to proceed</h2>
            <p>
                Now you can shop from the comfort of your home!! Shop at Gilded Rose Online store. All you have to do is:
                <ul>
                    <li>Login / sign up </li>
                    <li>Select the product you want to purchase</li>
                    <li>Click purchase </li>
                    <li>Enter your shipping/billing information</li>
                    <li>Checkout and pay</li>
                </ul>
            </p>
            <p>
                <a class="btn btn-default" href="About.aspx">Go shopping &raquo;</a>
            </p>
        </div>
        <%--<div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>--%>
    </div>

</asp:Content>
