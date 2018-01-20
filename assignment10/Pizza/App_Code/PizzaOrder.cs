using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PizzaOrder
/// </summary>
public class PizzaOrder
{
    public List<string> Pies { set; get; }
    public List<string> Toppings { set; get; }
    public PizzaOrder()
    {
        Pies = new List<string>();
        Toppings = new List<string>();
    }

    public void AddPie(string item)
    {
        Pies.Add(item);
    }

    public void AddTopping (string item)
    {
        Toppings.Add(item);
    }
    /*{ "small - 9 inches", "medium - 12 inches", "large - 16 inches" }*/
    public double CalculateTotal()
    {
        double total = 0;
        foreach (string pie in Pies)
        {
            if (pie == "small - 9 inches")
                {
                total += 9.99;
                }
             else if (pie == "medium - 12 inches")
                {
                total += 12.12;
                }
            else if (pie == "large - 16 inches")
                {
                total += 16.16;
                }
        }
        foreach (string toppings in Toppings)
        {
            total += 1;
        }
        return total;
    }
}