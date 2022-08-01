using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace BTLtestt
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["cart"] = new List<ProductList>();
            Application["products"] = new List<ProductList>();
            Application["user"] = new List<User>();


            //ví dụ về cấu trúc list khi nhập dữ liệu bằng tay
            //List<Part> parts = new List<Part>();
            //parts.Add(new Part() { PartName = "crank arm", PartId = 1234 });
            //parts.Add(new Part() { PartName = "chain ring", PartId = 1334 });
            //parts.Add(new Part() { PartName = "regular seat", PartId = 1434 });
            //parts.Add(new Part() { PartName = "banana seat", PartId = 1444 });




            // arr.Add(new DsSanPham(){ id = "1", img = "assets/img/l.jpg", name = ")", price = "",detail = "C",type = "3"});

            List<ProductList> arrProduct = new List<ProductList>();
            //Adidas
            arrProduct.Add(new ProductList() { id = "1", img = "1a25543be9abfa4d74ac570339416705", name = "Adidas Alphabounce", price = "999.000", detail = "Adidas - Trắng - Kiểu dáng không cầu kỳ mà rất thanh lịch, đơn giản và nhẹ nhàng, phù hợp với nhiều loại trang phục, thiết kế với phong cách thể thao, cá tính, mạnh mẽ, chất liệu vải cao cấp, màu sắc đa dạng, bền đẹp, phong phú về kiểu dáng, có kiểu giày cổ thấp và kiểu giày cổ cao, phù hợp cho các bạn trẻ đi học, vui chơi, thể thao, tha hồ dạo phố và du ngoạn, mang đến cảm giác thoải mái nhất cho người dùng.", type = "Giày Adidas" });
            arrProduct.Add(new ProductList() { id = "2", img = "f5911e18e42f093c23819c79cf253333", name = "Adidas EQT 2017", price = "899.000", detail = "Adidas - Trắng đen - Kiểu dáng không cầu kỳ mà rất thanh lịch, đơn giản và nhẹ nhàng, phù hợp với nhiều loại trang phục, thiết kế với phong cách thể thao, cá tính, mạnh mẽ, chất liệu vải cao cấp, màu sắc đa dạng, bền đẹp, phong phú về kiểu dáng, có kiểu giày cổ thấp và kiểu giày cổ cao, phù hợp cho các bạn trẻ đi học, vui chơi, thể thao, tha hồ dạo phố và du ngoạn, mang đến cảm giác thoải mái nhất cho người dùng.", type = "Giày Adidas" });
            arrProduct.Add(new ProductList() { id = "3", img = "image/Adidas/adi3.png", name = "Adidas UltraBoost 2017", price = "950.000", detail = "Adidas - Hồng cam - Kiểu dáng không cầu kỳ mà rất thanh lịch, đơn giản và nhẹ nhàng, phù hợp với nhiều loại trang phục, thiết kế với phong cách thể thao, cá tính, mạnh mẽ, chất liệu vải cao cấp, màu sắc đa dạng, bền đẹp, phong phú về kiểu dáng, có kiểu giày cổ thấp và kiểu giày cổ cao, phù hợp cho các bạn trẻ đi học, vui chơi, thể thao, tha hồ dạo phố và du ngoạn, mang đến cảm giác thoải mái nhất cho người dùng.", type = "Giày Adidas" });
            arrProduct.Add(new ProductList() { id = "4", img = "image/Adidas/adi4.png", name = "Adidas Stan Smith", price = "799.000", detail = "Adidas - Đen - Kiểu dáng không cầu kỳ mà rất thanh lịch, đơn giản và nhẹ nhàng, phù hợp với nhiều loại trang phục, thiết kế với phong cách thể thao, cá tính, mạnh mẽ, chất liệu vải cao cấp, màu sắc đa dạng, bền đẹp, phong phú về kiểu dáng, có kiểu giày cổ thấp và kiểu giày cổ cao, phù hợp cho các bạn trẻ đi học, vui chơi, thể thao, tha hồ dạo phố và du ngoạn, mang đến cảm giác thoải mái nhất cho người dùng.", type = "Giày Adidas" });
            arrProduct.Add(new ProductList() { id = "5", img = "image/Adidas/adi5.png", name = "Adidas Prophere", price = "990.000", detail = "Adidas - Đen - Kiểu dáng không cầu kỳ mà rất thanh lịch, đơn giản và nhẹ nhàng, phù hợp với nhiều loại trang phục, thiết kế với phong cách thể thao, cá tính, mạnh mẽ, chất liệu vải cao cấp, màu sắc đa dạng, bền đẹp, phong phú về kiểu dáng, có kiểu giày cổ thấp và kiểu giày cổ cao, phù hợp cho các bạn trẻ đi học, vui chơi, thể thao, tha hồ dạo phố và du ngoạn, mang đến cảm giác thoải mái nhất cho người dùng.", type = "Giày Adidas" });
            arrProduct.Add(new ProductList() { id = "6", img = "image/Adidas/adi6.png", name = "Adidas Pureboost", price = "1299.000", detail = "Adidas - Trắng - Kiểu dáng không cầu kỳ mà rất thanh lịch, đơn giản và nhẹ nhàng, phù hợp với nhiều loại trang phục, thiết kế với phong cách thể thao, cá tính, mạnh mẽ, chất liệu vải cao cấp, màu sắc đa dạng, bền đẹp, phong phú về kiểu dáng, có kiểu giày cổ thấp và kiểu giày cổ cao, phù hợp cho các bạn trẻ đi học, vui chơi, thể thao, tha hồ dạo phố và du ngoạn, mang đến cảm giác thoải mái nhất cho người dùng.", type = "Giày Adidas" });
            arrProduct.Add(new ProductList() { id = "7", img = "image/Adidas/adi7.png", name = "Adidas Tubular", price = "1099.000", detail = "Adidas - Trắng - Kiểu dáng không cầu kỳ mà rất thanh lịch, đơn giản và nhẹ nhàng, phù hợp với nhiều loại trang phục, thiết kế với phong cách thể thao, cá tính, mạnh mẽ, chất liệu vải cao cấp, màu sắc đa dạng, bền đẹp, phong phú về kiểu dáng, có kiểu giày cổ thấp và kiểu giày cổ cao, phù hợp cho các bạn trẻ đi học, vui chơi, thể thao, tha hồ dạo phố và du ngoạn, mang đến cảm giác thoải mái nhất cho người dùng.", type = "Giày Adidas" });
            arrProduct.Add(new ProductList() { id = "8", img = "image/Adidas/adi8.png", name = "Adidas EQT Cushion", price = "999.000", detail = "Adidas - Đỏ - Kiểu dáng không cầu kỳ mà rất thanh lịch, đơn giản và nhẹ nhàng, phù hợp với nhiều loại trang phục, thiết kế với phong cách thể thao, cá tính, mạnh mẽ, chất liệu vải cao cấp, màu sắc đa dạng, bền đẹp, phong phú về kiểu dáng, có kiểu giày cổ thấp và kiểu giày cổ cao, phù hợp cho các bạn trẻ đi học, vui chơi, thể thao, tha hồ dạo phố và du ngoạn, mang đến cảm giác thoải mái nhất cho người dùng.", type = "Giày Adidas" });

            //Nike
            arrProduct.Add(new ProductList() { id = "9", img = "image/Nike/nike1.png", name = "Nike Air Max", price = "799.000", detail = "Nike - Thiết kế trẻ trung; kiểu dáng thể thao, năng động, màu sắc đa dạng, tươi mới, phù hợp với mọi lứa tuổi, giày form chuẩn, đi êm chân, thoải mái không gò bó, giày có nhiều size, đủ size nam nữ, thích hợp với mọi kích thước chân, đế giày cao su bền chắc, chống trơn trượt tốt, có độ chống dính cao.", type = "Giày Nike" });
            arrProduct.Add(new ProductList() { id = "10", img = "image/Nike/nike2.png", name = "Nike Air Force 1", price = "990.000", detail = "Nike - Thiết kế trẻ trung; kiểu dáng thể thao, năng động, màu sắc đa dạng, tươi mới, phù hợp với mọi lứa tuổi, giày form chuẩn, đi êm chân, thoải mái không gò bó, giày có nhiều size, đủ size nam nữ, thích hợp với mọi kích thước chân, đế giày cao su bền chắc, chống trơn trượt tốt, có độ chống dính cao.", type = "Giày Nike" });
            arrProduct.Add(new ProductList() { id = "11", img = "image/Nike/nike3.png", name = "Nike Zoom", price = "890.000", detail = "Nike - Thiết kế trẻ trung; kiểu dáng thể thao, năng động, màu sắc đa dạng, tươi mới, phù hợp với mọi lứa tuổi, giày form chuẩn, đi êm chân, thoải mái không gò bó, giày có nhiều size, đủ size nam nữ, thích hợp với mọi kích thước chân, đế giày cao su bền chắc, chống trơn trượt tốt, có độ chống dính cao.", type = "Giày Nike" });
            arrProduct.Add(new ProductList() { id = "12", img = "image/Nike/nike4.png", name = "Nike Flyknit", price = "499.000", detail = "Nike - Thiết kế trẻ trung; kiểu dáng thể thao, năng động, màu sắc đa dạng, tươi mới, phù hợp với mọi lứa tuổi, giày form chuẩn, đi êm chân, thoải mái không gò bó, giày có nhiều size, đủ size nam nữ, thích hợp với mọi kích thước chân, đế giày cao su bền chắc, chống trơn trượt tốt, có độ chống dính cao.", type = "Giày Nike" });
            arrProduct.Add(new ProductList() { id = "13", img = "image/Nike/nike5.png", name = "Nike SF-AF1 “Desert Camo", price = "899.000", detail = "Nike - Thiết kế trẻ trung; kiểu dáng thể thao, năng động, màu sắc đa dạng, tươi mới, phù hợp với mọi lứa tuổi, giày form chuẩn, đi êm chân, thoải mái không gò bó, giày có nhiều size, đủ size nam nữ, thích hợp với mọi kích thước chân, đế giày cao su bền chắc, chống trơn trượt tốt, có độ chống dính cao.", type = "Giày Nike" });
            arrProduct.Add(new ProductList() { id = "14", img = "image/Nike/nike6.png", name = "Nike Air TR 17", price = "809.000", detail = "Nike - Thiết kế trẻ trung; kiểu dáng thể thao, năng động, màu sắc đa dạng, tươi mới, phù hợp với mọi lứa tuổi, giày form chuẩn, đi êm chân, thoải mái không gò bó, giày có nhiều size, đủ size nam nữ, thích hợp với mọi kích thước chân, đế giày cao su bền chắc, chống trơn trượt tốt, có độ chống dính cao.", type = "Giày Nike" });
            arrProduct.Add(new ProductList() { id = "15", img = "image/Nike/nike7.png", name = "Nike Cortez OG", price = "649.000", detail = "Nike - Thiết kế trẻ trung; kiểu dáng thể thao, năng động, màu sắc đa dạng, tươi mới, phù hợp với mọi lứa tuổi, giày form chuẩn, đi êm chân, thoải mái không gò bó, giày có nhiều size, đủ size nam nữ, thích hợp với mọi kích thước chân, đế giày cao su bền chắc, chống trơn trượt tốt, có độ chống dính cao.", type = "Giày Nike" });
            arrProduct.Add(new ProductList() { id = "16", img = "image/Nike/nike8.png", name = "Nike Air Jordan 1 “Royal”", price = "799.000", detail = "Nike - Thiết kế trẻ trung; kiểu dáng thể thao, năng động, màu sắc đa dạng, tươi mới, phù hợp với mọi lứa tuổi, giày form chuẩn, đi êm chân, thoải mái không gò bó, giày có nhiều size, đủ size nam nữ, thích hợp với mọi kích thước chân, đế giày cao su bền chắc, chống trơn trượt tốt, có độ chống dính cao.", type = "Giày Nike" });

            //Converse
            arrProduct.Add(new ProductList() { id = "17", img = "image/Converse/cv1.png", name = "Giày Converse Classic", price = "879.000", detail = "Converse - Chất liệu đế đúc, vải canvas; Đế độn 3cm; Màu sắc: 4 màu: trắng full, đen full, vàng, đỏ 41 42 43; Kiểu dáng: giày thể thao cổ cao đế độn form ôm khít; Độ tuổi: 18-40.", type = "Giày Converse" });
            arrProduct.Add(new ProductList() { id = "18", img = "image/Converse/cv2.png", name = "Converse 1970s", price = "1250.000", detail = "Converse - Chất liệu đế đúc, vải canvas; Đế độn 3cm; Màu sắc: 4 màu: trắng full, đen full, vàng, trắng đen ; Kiểu dáng: giày thể thao cổ thấp đế độn form ôm khít; Độ tuổi: 18-40.", type = "Giày Converse" });
            arrProduct.Add(new ProductList() { id = "19", img = "image/Converse/cv3.png", name = "Converse Jack Purcell", price = "789.000", detail = "Converse - Chất liệu đế đúc, vải canvas; Đế độn 3cm; Màu sắc: 4 màu: trắng full, đen full, vàng, trắng đen 41 42 43; Kiểu dáng: giày thể thao cổ cao đế độn form ôm khít; Độ tuổi: 18-40.", type = "Giày Converse" });
            arrProduct.Add(new ProductList() { id = "20", img = "image/Converse/cv4.png", name = "Converse One Star", price = "1090.000", detail = "Converse - Chất liệu đế đúc, vải canvas; Đế độn 3cm; Màu sắc: 4 màu: trắng full, đen full, vàng, trắng đen ; Kiểu dáng: giày thể thao cổ thấp đế độn form ôm khít; Độ tuổi: 18-40.", type = "Giày Converse" });
            arrProduct.Add(new ProductList() { id = "21", img = "image/Converse/cv5.png", name = "Converse Chuck Taylor All Star", price = "890.300", detail = "Converse - Chất liệu đế đúc, vải canvas; Đế độn 3cm; Màu sắc: 4 màu: trắng full, đen full, vàng đất; Kiểu dáng: giày thể thao cổ thấp đế độn form ôm khít; Độ tuổi: 18-40.", type = "Giày Converse" });
            arrProduct.Add(new ProductList() { id = "22", img = "image/Converse/cv6.png", name = "Converse Chuck Taylor II", price = "790.000", detail = "Converse - Chất liệu đế đúc, vải canvas; Đế độn 3cm; Màu sắc: 4 màu: trắng full, đen full, vàng, trắng đen 41 42 43; Kiểu dáng: giày thể thao cổ cao đế độn form ôm khít; Độ tuổi: 18-40.", type = "Giày Converse" });
            arrProduct.Add(new ProductList() { id = "23", img = "image/Converse/cv7.png", name = "Converse Rubber", price = "799.000", detail = "Converse - Chất liệu đế đúc, vải canvas; Đế độn 3cm; Màu sắc: 4 màu: trắng full, đen full, vàng, nâu đất ; Kiểu dáng: giày thể thao cổ cao đế độn form ôm khít; Độ tuổi: 18-40.", type = "Giày Converse" });
            arrProduct.Add(new ProductList() { id = "24", img = "image/Converse/cv8.png", name = "Converse Dainty", price = "1290.500", detail = "Converse - Chất liệu đế đúc, vải canvas; Đế độn 3cm; Màu sắc: 4 màu: trắng full, đen full, vàng, trắng đen 41 42 43; Kiểu dáng: giày thể thao cổ cao đế độn form ôm khít; Độ tuổi: 18-40.", type = "Giày Converse" });


            //Balen
            arrProduct.Add(new ProductList() { id = "25", img = "image/Balen/balen1.png", name = "Balenciaga Triple S", price = "1990.040", detail = "Balenciaga - Trắng - Chất liệu vải cao cấp, đế giày cao su bền chắc, màu sắc đa dạng, bền đẹp", type = "Giày Balenciaga" });
            arrProduct.Add(new ProductList() { id = "26", img = "image/Balen/balen2.png", name = "Balenciaga Triple S", price = "990.180", detail = "Balenciaga - Trắng - Chất liệu vải cao cấp, đế giày cao su bền chắc, màu sắc đa dạng, bền đẹp", type = "Giày Balenciaga" });
            arrProduct.Add(new ProductList() { id = "27", img = "image/Balen/balen3.png", name = "Balenciaga Triple S", price = "969.000", detail = "Balenciaga - Trắng xanh - Chất liệu vải cao cấp, đế giày cao su bền chắc, màu sắc đa dạng, bền đẹp", type = "Giày Balenciaga" });
            arrProduct.Add(new ProductList() { id = "28", img = "image/Balen/balen4.png", name = "Balenciaga Triple S", price = "999.000", detail = "Balenciaga - Trắng - Chất liệu vải cao cấp, đế giày cao su bền chắc, màu sắc đa dạng, bền đẹp", type = "Giày Balenciaga" });
            arrProduct.Add(new ProductList() { id = "29", img = "image/Balen/balen5.png", name = "Balenciaga Triple S", price = "690.300", detail = "Balenciaga - Trắng đen - Chất liệu vải cao cấp, đế giày cao su bền chắc, màu sắc đa dạng, bền đẹp", type = "Giày Balenciaga" });
            arrProduct.Add(new ProductList() { id = "30", img = "image/Balen/balen6.png", name = "Balenciaga Triple S", price = "900.250", detail = "Balenciaga - Trắng vàng - Chất liệu vải cao cấp, đế giày cao su bền chắc, màu sắc đa dạng, bền đẹp", type = "Giày Balenciaga" });
            arrProduct.Add(new ProductList() { id = "31", img = "image/Balen/balen7.png", name = "Balenciaga Triple S", price = "1990.250", detail = "Balenciaga - Đen - Chất liệu vải cao cấp, đế giày cao su bền chắc, màu sắc đa dạng, bền đẹp", type = "Giày Balenciaga" });
            arrProduct.Add(new ProductList() { id = "32", img = "image/Balen/balen8.png", name = "Balenciaga Triple S", price = "1090.500", detail = "Balenciaga - Trắng đen - Chất liệu vải cao cấp, đế giày cao su bền chắc, màu sắc đa dạng, bền đẹp", type = "Giày Balenciaga" });

            //Vans
            arrProduct.Add(new ProductList() { id = "33", img = "image/Vans/vans1.png", name = "Vans Old Skool", price = "549.040", detail = "Vans - Đỏ - Giày thể thao chất lượng cao phù hợp với mọi lứa tuổi, phối đồ cực đẹp, giá thành lại cực rẻ, bền và đẹp, nhất là đối với sinh viên học sinh . ", type = "Giày Vans" });
            arrProduct.Add(new ProductList() { id = "34", img = "image/Vans/vans2.png", name = "Vans Classic Authentic", price = "890.180", detail = "Vans - Đen - Giày thể thao chất lượng cao phù hợp với mọi lứa tuổi, phối đồ cực đẹp, giá thành lại cực rẻ, bền và đẹp, nhất là đối với sinh viên học sinh . ", type = "Giày Vans" });
            arrProduct.Add(new ProductList() { id = "35", img = "image/Vans/vans3.png", name = "Vans Slip On", price = "549.000", detail = "Vans - Trắng - Giày thể thao chất lượng cao phù hợp với mọi lứa tuổi, phối đồ cực đẹp, giá thành lại cực rẻ, bền và đẹp, nhất là đối với sinh viên học sinh . ", type = "Giày Vans" });
            arrProduct.Add(new ProductList() { id = "36", img = "image/Vans/vans4.png", name = "Vans Era", price = "849.000", detail = "Vans - Đen trắng - Giày thể thao chất lượng cao phù hợp với mọi lứa tuổi, phối đồ cực đẹp, giá thành lại cực rẻ, bền và đẹp, nhất là đối với sinh viên học sinh . ", type = "Giày Vans" });
            arrProduct.Add(new ProductList() { id = "37", img = "image/Vans/vans5.png", name = "Vans Sk8-Hi", price = "699.300", detail = "Vans - Đen trắng - Giày thể thao chất lượng cao phù hợp với mọi lứa tuổi, phối đồ cực đẹp, giá thành lại cực rẻ, bền và đẹp, nhất là đối với sinh viên học sinh . ", type = "Giày Vans" });
            arrProduct.Add(new ProductList() { id = "38", img = "image/Vans/vans6.png", name = "Vans Anaheim Factory Style 73 DX", price = "999.020", detail = "Vans - Đen trắng - Giày thể thao chất lượng cao phù hợp với mọi lứa tuổi, phối đồ cực đẹp, giá thành lại cực rẻ, bền và đẹp, nhất là đối với sinh viên học sinh . ", type = "Giày Vans" });
            arrProduct.Add(new ProductList() { id = "39", img = "image/Vans/vans7.png", name = "Vans Classic ComfyCush Era", price = "1544.250", detail = "Vans - Hồng - Giày thể thao chất lượng cao phù hợp với mọi lứa tuổi, phối đồ cực đẹp, giá thành lại cực rẻ, bền và đẹp, nhất là đối với sinh viên học sinh . ", type = "Giày Vans" });
            arrProduct.Add(new ProductList() { id = "40", img = "image/Vans/vans8.png", name = "Vans x FOG", price = "414.500", detail = "Vans - Xanh đen - Giày thể thao chất lượng cao phù hợp với mọi lứa tuổi, phối đồ cực đẹp, giá thành lại cực rẻ, bền và đẹp, nhất là đối với sinh viên học sinh . ", type = "Giày Vans" });

            Application["products"] = arrProduct;

            List<User> arrUser = new List<User>();
            arrUser.Add(new User() { email = "toan@gmail.com", name = "Le Thang Toan", password = "abcABC12", repassword = "abcABC12" });
            Application["user"] = arrUser;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["login"] = 0;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}