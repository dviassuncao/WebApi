using System.Collections.Generic;
using WebAPI.Models;

namespace WebAPI.FilaItems
{
    public class Fila : IFila
    {
        private Queue<List<Item>> items;
        public Queue<List<Item>> Items
        {
            get
            {
                if (items == null)
                    items = new Queue<List<Item>>();
                return items;
            }
            set { items = value; }
        }
    }
}
