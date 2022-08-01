<%@ Page  EnableEventValidation="false" Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="cart.aspx.cs" Inherits="BTLtestt.cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="cart_container">
       <p class="cart_head">Giỏ hàng của bạn: <small class="product_count">(<asp:Label ID="TotalProductCount" runat="server" Text=""></asp:Label> sản phẩm) </small></p>
       <div class="cart_left">
           <asp:ListView ID="Cart" runat="server" >
               <ItemTemplate>
                   <div class="cart_content_left">
                       <img src="<%# Eval("img") %>" width="150"/>
                   </div>
                   <div class="cart_content_right">
                       <p><%# Eval("name")%></p>
                       <a href="products_detail.aspx?id=<%# Eval("id") %>">Chi tiết</a>
                       <strong><%# Eval("price") %>đ</strong>
                       <asp:Button ID="btnRemove" runat="server" Text="X" CommandArgument='<%# Eval("id") %>'  CssClass="btnRemove" OnClick ="btnRemove_Click" />
                       
                   </div>
                  
								<div class="cart_quantity_button">
									<a class="cart_quantity_down" href="#"> - </a>
									<input class="cart_quantity_input" type="text" name="quantity" value="1" autocomplete="off" size="2">
									<a class="cart_quantity_up" href="#"> + </a>
								</div>
							

                   <!-- <OnClientClick="if(!Xacnhan_Xoa()) return false;"/>--> 
               </ItemTemplate>
            </asp:ListView>
       </div>
       <div class="cart_right">
           <div id="cart_right_cost1">Tạm tính: <p class="lblTotalPriceProduct1"><asp:Label ID="TotalPriceProduct" runat="server" Text="" ></asp:Label>đ</p></div>
           <div id="cart_right_cost2">Thành tiền: <p class ="lblTotalPriceProduct2"><asp:Label ID="TotalPriceProduct1" runat="server" Text=""></asp:Label>đ</p></div>
       </div>
   </div>

</asp:Content>
