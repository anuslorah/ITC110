using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectexample2
{
    public class Item //this just stores two things
    {
        public string ItemName { get; set; } //no other language lets you create a property 
        //like this, underneath it creates a private property with lowercase i
        public double ItemPrice { get; set; }

    }
}
