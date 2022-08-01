<%@ Page Title="Cửa hàng thời trang" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="BTLtestt.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<%--    <link href="index.css" rel="stylesheet" />--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
		<div class="banner">
            <img src="image/banner_1.jpg" />
		</div>
		<div class="content">
			<center>
				
				<h3>SẢN PHẦM BÁN CHẠY NHẤT</h3>
				<hr class="hr2" />
                <hr class="hr1" />
			</center>
			<div class="products_container"> 
                    <asp:ListView ID="ListViewFeaturedProducts" runat="server">
                       <ItemTemplate>
                             <div class="products_container_cols">                   
                                    <a href="products_detail.aspx?id=<%# Eval("id") %>">
                                        <img src="<%# Eval("img") %>" alt="" />
                                    </a>
                                    <div class="products_text">
                                        <p class="products_text1"><%# Eval("name") %></p>
                                        <p class="products_text2"><strong><%# Eval("price") %>đ</strong></p>                          
                                    </div>
                              </div>   
                        </ItemTemplate>
                    </asp:ListView>
                </div>

            <center>
			
				<h3>SẢN PHẦM MỚI NHẤT</h3>
				<hr class="hr2" />
                <hr class="hr1" />
			</center>
                <div class="products_container"> 
                    <asp:ListView ID="ListViewNewProducts" runat="server">
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
            </div>
</asp:Content>

