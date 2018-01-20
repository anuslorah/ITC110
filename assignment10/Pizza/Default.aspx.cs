using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PopulatePie();
            PopulateToppings();
        }
    }
    protected void PopulatePie()
    {
        string[] pie = { "small - 9 inches", "medium - 12 inches", "large - 16 inches" };
        CheckBoxPie.DataSource = pie;
        CheckBoxPie.DataBind();
    }

    protected void PopulateToppings()
    {
        string[] toppings = { "kale", "garlic", "goat cheese", "olives" };
        CheckBoxTopping.DataSource = toppings;
        CheckBoxTopping.DataBind();
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        PizzaOrder order = new PizzaOrder();
        foreach (ListItem item in CheckBoxPie.Items)
        {
            if (item.Selected)
            {
                order.AddPie(item.Text);
            }
        }//foreach
        foreach (ListItem item in CheckBoxTopping.Items)
        {
            if (item.Selected)
            {
                order.AddTopping(item.Text);
            }
        }//foreach
        if (order.Pies.Count == 0 && order.Toppings.Count == 0)
        {
            Response.Redirect("Default.aspx");
        }
        Session["Order"] = order;
        Response.Redirect("Receipt.aspx");
    }//end of button
}
