using ChannelEngineModels;
using ChannelEngineService.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChannelEngine.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IProductService _productService;
        private readonly IConfiguration _configuration;

        public OrderController(IOrderService orderService, IProductService productService, IConfiguration configuration)
        {
            _orderService = orderService;
            _productService = productService;
            _configuration = configuration;
        }

        public ActionResult Index()
        {
            var status = _configuration["ChannelEngineSettings:Status"];
            var orders = _orderService.GetOrders(status).Result;
            var allProducts = GetProducts(orders.Content);
            var count = Convert.ToInt32(_configuration["ChannelEngineSettings:ProductCount"]);
            var products =  _productService.GetProductDetails(allProducts, count).Result;

            return View(products.ToList());
        }

        [HttpPost]
        public IActionResult UpdateStock(ChannelEngine.Models.ProductResponse  products)
        {
            var updateProductRequest = new UpdateProductRequest()
            {
                MerchantProductNo = products.MerchantProductNo,
                StockLocations = new StockLocation[1]
                {
                    new StockLocation()
                    {
                        Stock = products.ProductCount,
                        StockLocationId = 1
                    }
                }
            };
            var response = _productService.UpdateProductStock(updateProductRequest).Result;
            return Ok();
        }

        // GET: OrderController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrderController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private static IEnumerable<Line> GetProducts(IEnumerable<Content> orders)
        {
            var allProducts = new List<Line>();
            foreach (var order in orders)
            {
                allProducts.AddRange(order.Lines);
            }
            return allProducts;
        }
    }
}
