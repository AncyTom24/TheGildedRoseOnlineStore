<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
    CodeBehind="productLists.aspx.cs" Inherits="TheGildedRoseOnlineStore.productLists" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Our products</h1>
    <asp:Repeater runat="server" ID="rptProducts" OnItemCommand="rptProducts_ItemCommand">
        <HeaderTemplate>
            <div class="row">
        </HeaderTemplate>
        <ItemTemplate>

            <div class="col-md-3 box-shadow">
                <asp:Image runat="server" ID="imgProduct" CssClass="card-img-top" 
                    ImageUrl="~/Images/thumb1.jpg"
                    AlternateText="Thumbnail [100%x225]" Width="100%"/>              
                <div class="card-body">
                    <asp:Label runat="server" ID="lblProductName" Font-Bold="true" 
                        Text='<%# Eval("productName") %>'></asp:Label>
                    <br />
                    <asp:Label runat="server" ID="lblProductDescription" 
                        Text='<%# Eval("productDescription") %>'></asp:Label>
                    <div class="d-flex justify-content-between align-items-center">
                        <div class="btn">
                            <asp:Button runat="server" ID="btnBuyNow" 
                                CommandArgument='<%# Eval("id") %>' OnClick="btnBuyNow_Click" BackColor="Blue" ForeColor="Wheat" CommandName="Buy" Text="Buy Now"
                                CssClass="btn btn-sm btn-outline-secondary" />
                        </div>
                    </div>
                </div>
            </div>
        </ItemTemplate>
        <FooterTemplate>
            </div>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
