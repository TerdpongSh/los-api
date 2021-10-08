using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using los_api.Models;

namespace los_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductStockController : Controller
    {
        private readonly ProductStockContext _Context;

        // GET: api/ProductStocks/5
        /*[HttpGet("{productId}")]
        public async Task<ActionResult<ProductStock>> GetStockByProductId(int productId)
        {
            var stock = await _Context.Stocks.FindAsync(productId);
            var product = await _Context.Products.FindAsync(productId);

            var productStock = new ProductStock()
            {
                productId = productId,
                name = product.name,
                imageUrl = product.imageUrl,
                pricePerEach = product.price,
                amount = stock.amount
            };
            if (productStock == null)
            {
                return NotFound();
            }

            return productStock;
        }
        */
    }
}
