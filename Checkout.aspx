<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="TheGildedRoseOnlineStore.Checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <div class="signup-form">
                <form action="POST" method="post">
                    <h2>Checkout</h2>
                    <p>Fill your address and checkout</p>
                    <hr>
                    <div class="form-group">
                        <asp:TextBox runat="server" ID="txtName" CssClass="form-control" Placeholder="Full name"></asp:TextBox>                        
                    </div>
                    <div class="form-group">
                        <asp:TextBox runat="server" ID="txtPhoneNumber" CssClass="form-control" Placeholder="Phone number"></asp:TextBox>                        
                    </div>
                    <div class="form-group">
                        <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" Placeholder="Email"></asp:TextBox>                        
                    </div>
                    <div class="form-group">
                        <asp:TextBox runat="server" ID="txtAddress" CssClass="form-control" TextMode="MultiLine" Placeholder="Address"></asp:TextBox>                        
                    </div>
                    <div class="form-group">
                        <asp:Button runat="server" ID="btnCheckout" 
                            CssClass="btn btn-primary btn-lg" Text="Proceed to payment" OnClick="btnCheckout_Click" />                        
                    </div>
                </form>
            </div>
    </div>
</asp:Content>
