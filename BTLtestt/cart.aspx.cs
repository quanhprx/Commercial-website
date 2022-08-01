using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLtestt
{
    public partial class cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            decimal totalprice = 0;
            List<ProductList> arrCart = (List<ProductList>)Application["cart"];
            foreach (ProductList sp in arrCart)
            {
                totalprice += decimal.Parse(sp.price);
            }
            Cart.DataSource = arrCart;
            Cart.DataBind();
            TotalProductCount.Text = arrCart.Count.ToString();
            TotalPriceProduct.Text = totalprice.ToString();
            TotalPriceProduct1.Text = totalprice.ToString();
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
     
                string id = ((Button)sender).CommandArgument.ToString();
                List<ProductList> arrCart = (List<ProductList>)Application["cart"];
                foreach (ProductList sp in arrCart)
                {
                    if (sp.id == id)
                    {
                        arrCart.Remove(sp);
                        break;

                    }
                }
                Application["cart"] = arrCart;
                Cart.DataSource = arrCart;
                Cart.DataBind();
                TotalProductCount.Text = arrCart.Count.ToString();
                Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }
    }
}
