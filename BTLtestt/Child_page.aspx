<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Child_page.aspx.cs" Inherits="BTLtestt.Child_page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="head_type"><asp:Label ID="products_Type" runat="server" Text="Label"></asp:Label></h1>
    <div class="products_container">
        <asp:ListView ID="ListViewProductsType" runat="server">
            <ItemTemplate>
                 <div class="products_container_cols">                   
                       <a href="products_detail.aspx?id=<%# Eval("id") %>">
                          <img src="<%# Eval("img") %>" />
                       </a>
                       <div class="products_text">
                          <p class="products_text1"><%# Eval("name") %></p>
                          <p class="products_text2"><strong><%# Eval("price") %>đ</strong></p>                          
                       </div>
                  </div>   
            </ItemTemplate>
        </asp:ListView>
     </div>  
</asp:Content>
