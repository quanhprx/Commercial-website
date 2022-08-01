function Dangnhap() {
    var tk = document.getElementById("Email").value;
    var mk = document.getElementById("Pass").value;
    var loi1 = document.getElementById("Pass").value;
    var ErrMsg = document.getElementById("Error");
    if (tk == "" || mk == "") {
        ErrMsg.style.display = "block";
        ErrMsg.style.color = "red";
        alert("Lỗi");
        return false;
    }
    else {
        ErrMsg.style.display = "none";
        alert("Đúng!");
        return true;
    }
}

function Dangky() {
    var tk = document.getElementById("txtName");
    var email = document.getElementById("email");
    var mk = document.getElementById("password");
    var lmk = document.getElementById("repassword");
    var vnf_regex = /((09|03|07|08|05)+([0-9]{8})\b)/g;
    var mobile = $('#mobile').val();
    var regMail = /^([a-zA-Z0-9](\.|_)?)+([a-zA-Z0-9])+\@([a-zA-Z0-9])+(\.?[a-zA-Z0-9]){2}\.[a-z]{2,3}$/;
    var loi = "";
    dem = 0;
  
    if (tk.value == "" || mk.value == "" || lmk.value == "" || email.value == "") {
    
        dem++;
        loi += "\n Bạn phải nhập đủ thông tin";
    }
    
    if (!regMail.test(email.value)) {
        dem++;
        loi += "\n Email chua dung dang";
        var t = document.getElementById("loiemail");
        t.innerHTML = "Email chưa đúng dạng";
    }
    var a1 = /[0-9]/, b1 = /[a-z]/, c1 = /[A-Z]/;
    if (mk.value.length < 8) {
       
        dem++;
        loi += "\n Bạn  phải nhập mật khẩu lớn hơn hoặc bằng 8 kí tự!";
    }

    
    if ((!a1.test(mk.value)) || (!b1.test(mk.value)) || (!c1.test(mk.value))) {
        dem++;
        loi += "\n Mật khẩu phải đủ số, chữ hoa, chữ thường";
    }
    if (mk.value != lmk.value) {
        dem++;
        loi += "\n Mật khẩu nhập lại phải giống nhau!";
    }
    if (dem != 0) {
        alert(loi);
        return false;
    }
    else return true;
    
}

    


function Xacnhan_Xoa() {
    var t = confirm("Bạn co chac se xoa san pham khoi gio hang!");
    return t;
}