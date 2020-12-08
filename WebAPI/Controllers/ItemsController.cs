using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.FilaItems;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly ILogger<ItemsController> _logger;
        private readonly IFila _fila;

        public ItemsController(ILogger<ItemsController> logger, IFila fila)
        {
            _logger = logger;
            _fila = fila;
        }

        public IActionResult GetItemFila()
        {
            if (_fila.Items == null || _fila.Items.Count == 0)
                return NoContent();

            List<Item> items = _fila.Items.Peek();
            _fila.Items.Dequeue();
            return Ok(items);
        }

        [HttpPost]
        public IActionResult AddItemFila([FromBody] List<Item> moedas)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _fila.Items.Enqueue(moedas);

            return Ok();
        }
    }
}
