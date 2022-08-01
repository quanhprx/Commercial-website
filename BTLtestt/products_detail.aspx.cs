using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLtestt
{
    public partial class products_detail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == null)
            {
                Response.Redirect("index.aspx", true);

            }
            else
            {
                List<ProductList> arrProducts = (List<ProductList>)Application["products"];
                foreach (ProductList sp in arrProducts)
                {
                    if (sp.id == Request.QueryString["id"])
                    {
                        img.ImageUrl = sp.img;
                        lblName.Text = sp.name;
                        lblFeature.Text = sp.detail;
                        lblPrice.Text = sp.price;
                        btnCart.CommandArgument = sp.id;
                    }
                }
            }
        }

        protected void btnCart_Click(object sender, EventArgs e)
        {
            string id = ((Button)sender).CommandArgument.ToString();

            List<ProductList> arrCart = (List <ProductList>)Application["cart"];
            List<ProductList> arrProducts = (List<ProductList>)Application["products"];

            if(arrCart.Count == 0)
            {
                arrCart = new List<ProductList>();
            }
            foreach(ProductList sp in arrProducts)
            {
                if(sp.id == id)
                {
                     arrCart.Add(sp);
                     break;
                }
            }
            Application["cart"] = arrCart;
            Response.Redirect("cart.aspx");
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }
    }
}