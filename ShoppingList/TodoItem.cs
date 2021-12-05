using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList
{
    public class TodoItem
    {
        public string TodoName { get; set; }
        public int TodoQuantity { get; set; }

        public TodoItem()
        {

        }

        public override string ToString()
        {
            return $"{TodoQuantity}x {TodoName}";
        }
    }
}
