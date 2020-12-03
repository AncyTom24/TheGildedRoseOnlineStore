<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="TheGildedRoseOnlineStore.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Login / Sign up</h2>
    <div class="row">
        <div class="col-md-6">
            <div class="signup-form">
                <form action="POST" method="post">
                    <h2>Sign Up</h2>
                    <p>Please fill in this form to create an account!</p>
                    <hr>
                    <div class="form-group">
                        <asp:TextBox runat="server" ID="txtFullName" CssClass="form-control" Placeholder="Full Name"></asp:TextBox>
                        <%--<input type="text" class="form-control" name="full_name" placeholder="Full Name" required="required">--%>
                    </div>
                    <div class="form-group">
                        <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" Placeholder="Email"></asp:TextBox>
                       </div>
                    <div class="form-group">
                        <asp:TextBox runat="server" ID="txtPassword" CssClass="form-control" Placeholder="Password"></asp:TextBox>
                        </div>
                    <div class="form-group">
                        <asp:TextBox runat="server" ID="txtConfirmPassword" TextMode="Password" CssClass="form-control" Placeholder="Confirm Password"></asp:TextBox>
                        </div>
                    <div class="form-group">
                        <asp:Button runat="server" ID="btnSignUp" TextMode="Password" CssClass="btn btn-primary btn-lg" Text="Sign Up" OnClick="btnSignUp_Click" />
                        </div>
                    <div class="">
                        <asp:Label runat="server" ID="lblNotice" ></asp:Label>
                    </div>
                </form>

                <div class="hint-text">Already have an account? Login here</div>
            </div>
        </div>
        <div class="col-md-6">
            <div class="signup-form">
                <form action="productLists.aspx" method="post">
                    <h2>Login</h2>
                    <p>Fill your credentials and login</p>
                    <hr>
                    <div class="form-group">
                        <asp:TextBox runat="server" ID="txtLoginEmail" CssClass="form-control" Placeholder="Email"></asp:TextBox>                        
                    </div>
                    <div class="form-group">
                        <asp:TextBox runat="server" ID="txtLoginPassword" TextMode="Password" CssClass="form-control" Placeholder="Password"></asp:TextBox>                        
                    </div>
                    <div class="form-group">
                        <asp:Button runat="server" ID="btnLogin" 
                            CssClass="btn btn-primary btn-lg" Text="Login" OnClick="btnLogin_Click" />                        
                    </div>
                </form>
            </div>
        </div>
    </div>

</asp:Content>
