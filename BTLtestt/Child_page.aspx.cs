using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLtestt
{
    public partial class Child_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["type"] != null)
            {
                string type = Request.QueryString["type"];
                if (type == "Giày Adidas") { products_Type.Text = "<div class='giay_adidas'>&nbsp</div>"; }
                else if (type == "Giày Nike") { products_Type.Text = "<div class='giay_nike'>&nbsp</div>"; }
                else if (type == "Giày Balenciaga") { products_Type.Text = "<div class='giay_balenciaga'>&nbsp</div>"; }
                else if (type == "Giày Vans") { products_Type.Text = "<div class='giay_vans'>&nbsp</div>"; }
                else if (type == "Giày Converse") { products_Type.Text = "<div class='giay_converse'>&nbsp</div>"; }
                
                List<ProductList> arrProducts = (List<ProductList>)Application["products"];
                List<ProductList> arrType = new List<ProductList>();
                foreach (ProductList sp in arrProducts)
                {
                    if(sp.type == type)
                    {
                        arrType.Add(sp);
                    }
                }
                ListViewProductsType.DataSource = arrType;
                ListViewProductsType.DataBind();
            }
        }
    }
}