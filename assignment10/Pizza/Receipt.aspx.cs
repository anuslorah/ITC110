using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class Receipt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Order"]== null)
        {
            Response.Redirect("Default.aspx");
        }
        DisplayReceipt();
    }
    protected void DisplayReceipt()
    {
        StringBuilder ttl = new StringBuilder();
        PizzaOrder order = (PizzaOrder)Session["Order"];
        List<string> pie = order.Pies;
        List<string> toppings = order.Toppings;

        foreach(string Pie in pie)
        {
            ttl.Append(Pie);
            ttl.Append("<br/>");
        }
        foreach (string top in toppings)
        {
            ttl.Append(top);
            ttl.Append("<br/>");
        }
        ttl.Append(order.CalculateTotal().ToString());
        Label1.Text = ttl.ToString();
    }

}