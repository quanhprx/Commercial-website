using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLtestt
{
    public partial class Home : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"].ToString() == "1")
            {
                loregisterlogin.InnerHtml =
                    "Hello " + Session["name"].ToString() +
                    "<a href=\"logout.aspx\">Đăng xuất</a>";
                Session["url"] = Page.Request.Url.ToString();

            }
            else
            {
                loregisterlogin.InnerHtml = "<a href=\"login.aspx\">Đăng nhập</a>" +
                           "<a href=\"register.aspx\">Đăng ký</a> ";

            }
        }

        protected void btnSearch_click(object sender, EventArgs e)
        {
            if (txtsearch.Text == "adidas" || txtsearch.Text == "giày adidas") { Response.Redirect("Child_page.aspx?type=Giày Adidas"); }
            else if (txtsearch.Text == "nike" || txtsearch.Text == "giày nike") { Response.Redirect("Child_page.aspx?type=Giày Nike"); }
            else if (txtsearch.Text == "balenciaga" || txtsearch.Text == "giày balenciaga") { Response.Redirect("Child_page.aspx?type=Giày Balenciaga"); }
            else if (txtsearch.Text == "vans" || txtsearch.Text == "giày vans") { Response.Redirect("Child_page.aspx?type=Giày Vans"); }
            else if (txtsearch.Text == "converse" || txtsearch.Text == "giày converse") { Response.Redirect("Child_page.aspx?type=Giày Converse"); }
        }
    }
}