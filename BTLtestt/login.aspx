<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="BTLtestt.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="formDangNhap">
        <div class="head">Đăng nhập hệ thống quản trị website</div>
        <div class="controls">
            <div class="row">
                <div class="left">Email</div>
                <div class="right">
                    <input type="email" name="Email" id="Email" value="" placeholder="abc@gmail.com" required="required" />
                </div>
            </div>

            <div class="row">
                <div class="left">Mật khẩu</div>
                <div class="right">
                    <input type="password" name="Pass" id="Pass" value="" placeholder="8 ki tu (bao gom chu hoa).." required="required" />
                </div>
            </div>

            <div class="row">
                <div class="left">&nbsp</div>
                <div class="right">
                    <input type="submit" name="btnDangnhap" id="btnLogin" value="Đăng Nhập" onclick="return Dangnhap();" />
                </div>
            </div>

            <p style=" color: red">
                 <asp:Label ID="loidangnhap" runat="server"></asp:Label>
            </p>
        </div>
    </div>
</asp:Content>
