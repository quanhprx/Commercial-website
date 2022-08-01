using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLtestt
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<ProductList> arrList = (List<ProductList>)Application["products"];
            List<ProductList> arrFeaturedProducts = new List<ProductList>();
            List<ProductList> arrNewProducts = new List<ProductList>();
            foreach (ProductList sp in arrList)
            {
                int id = Int32.Parse(sp.id);
                if (id == 14 || id == 26 || id == 12 || id == 15 || id == 2 || id == 8 || id == 9 || id == 5||
                    id == 19 || id == 20 || id == 21 || id == 7)
                {
                    arrFeaturedProducts.Add(sp);
                }
                if (id == 4 || id == 22 || id == 13 || id == 16 || id == 34 || id == 24 || id == 20 || id == 11||
                    id == 10 || id == 40 || id == 38 || id == 30)
                {
                    arrNewProducts.Add(sp);
                }
            }
            ListViewFeaturedProducts.DataSource = arrFeaturedProducts;
            ListViewFeaturedProducts.DataBind();

            ListViewNewProducts.DataSource = arrNewProducts;
            ListViewNewProducts.DataBind();
        }
        protected void btnCart_Click(object sender, EventArgs e)
        {
            string id = ((Button)sender).CommandArgument.ToString();

            List<ProductList> arrCart = (List<ProductList>)Application["cart"];
            List<ProductList> arrProducts = (List<ProductList>)Application["products"];
            if (arrCart.Count == 0)
            {
                arrCart = new List<ProductList>();
            }

            foreach (ProductList sp in arrProducts)
            {
                if (sp.id == id)
                {
                    arrCart.Add(sp);
                    break;
                }
            }
            Application["cart"] = arrCart;
            Page.Response.Redirect(Page.Request.Url.ToString(), true);

        }
    }
}