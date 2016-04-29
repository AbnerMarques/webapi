using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    public class ProductController : ApiController
    {
        List<Product> listaDeProdutos = new List<Product>();


        // GET: api/Product
        public IHttpActionResult Get()
        {
            var produto1 = new Product();
            produto1.Id = 1;
            produto1.Name = "Placa de Rede";
            produto1.Category = "Hardware";
            produto1.Price = 120m;
            listaDeProdutos.Add(produto1);

            var produto2 = new Product();
            produto2.Id = 2;
            produto2.Name = "Memória DDR4";
            produto2.Category = "Hardware";
            produto2.Price = 80m;
            listaDeProdutos.Add(produto2);

            //Forma mais simples de um novo objeto 'Product'.
            var produto3 = new Product {Id = 3, Name = "Placa Mãe", Category = "Hardware", Price = 480m };
            listaDeProdutos.Add(produto3);
       
            return Ok(listaDeProdutos);
        }

        // GET: api/Product/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Product
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
}
