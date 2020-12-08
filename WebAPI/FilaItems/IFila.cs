using System.Collections.Generic;
using WebAPI.Models;

namespace WebAPI.FilaItems
{
    public interface IFila
    {
        Queue<List<Item>> Items { get; set; }
    }
}
