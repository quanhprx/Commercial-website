<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="products_detail.aspx.cs" Inherits="BTLtestt.products_detail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="product_detail_head">THÔNG TIN SẢN PHẨM</div>
    <div class="product_detail_container">
        <div class="product_detail_left">
            <asp:Image ID="img" runat="server" CssClass="product_detail_img"/>
        </div>
        <div class="product_detail_right">
            <div class="product_detail_right_name">
                <asp:Label ID="lblName" runat="server" Text=""></asp:Label>
            </div>
            <div class="product_detail_right_feature">
                <asp:Label ID="lblFeature" runat="server" Text=""></asp:Label>
            </div>
            <div class="product_detail_right_price">
                <p>Giảm giá nay chỉ còn: <asp:Label ID="lblPrice" runat="server" Text="" CssClass="lblprice"></asp:Label>₫</p>
            </div>
            <div class="product_detail_right_cart">
                <asp:Button ID="btnCart" runat="server" CommandArgument="" Text="MUA NGAY" CssClass="btnCart" OnClick="btnCart_Click"/>
            </div>
        </div>
    </div>
</asp:Content>
