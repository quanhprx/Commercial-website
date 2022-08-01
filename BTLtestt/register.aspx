<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="BTLtestt.register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="formDangNhap" >
        <div class="head">Đăng ký vào hệ thống quản trị website</div>
        <div class="controls">
            <div class="row">
                <div class="left">Họ và tên</div>
                <div class="right">
                    <input class="inputregister" type="text" id="txtName" value="" name="name" placeholder="Your name..." required="required"/>
                </div>
            </div>

            <div class="row">
                <div class="left">Email</div>
                <div class="right">
                    <input type="email" name="email" id="email" value="" placeholder="abc@gmail.com" required="required"/>
                     <!-- <label id="loiemail" class="loidangki"></label> -->
                </div>
            </div>
            <div class="row">
                <div class="left">Số điện thoại</div>
                <div class="right">
                    <input type="text" name="number" id="mobile" value="" placeholder="nhap so dien thoai" required="required"/>
                 
                </div>

            </div>
            <div class="row">
                <div class="left">Mật khẩu</div>
                <div class="right">
                    <input type="password" name="password" id="password" value="" placeholder="8 ki tu (gom ca chu hoa)..." required="required"/>
                </div>
            </div>

            <div class="row">
                <div class="left">Nhập lại mật khẩu</div>
                <div class="right">
                    <input type="password" name="repassword" id="repassword" value="" placeholder="8 ki tu (gom ca chu hoa)..." required="required"  />
                </div>
            </div>

            <div class="row">
                <div class="left">&nbsp</div>
                <div class="right">
                   
                    <input type="submit" name="btnRegister" id="btnRegister" value="Đăng Ký" onclick="return Dangky();" /> 
                </div>
            </div>
           
            <p style=" color: red">
                <asp:Label ID="loi" runat="server"></asp:Label>
            </p> 
        </div>
    </div>
</asp:Content>
