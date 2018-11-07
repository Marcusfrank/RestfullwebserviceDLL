using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BilletLibrary;

namespace RestFullWebServiceDLL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceController : ControllerBase
    {
        
        // GET: api/Price
        [HttpGet("/MC/Oresund")]
        public int GetPriceMCStore()
        {
            MC mc = new MC();

            return mc.Pris();
        }

        // GET: api/Price
        [HttpGet("/MC/")]
        public int GetPriceMC()
        {
            MCØresund mcØresund = new MCØresund();

            return mcØresund.Pris();
        }

        // GET: api/Price
        [HttpGet("/Bil/")]
        public int GetPriceBil()
        {
            Bil bil = new Bil();

            return bil.Pris();
        }

        // GET: api/Price
        [HttpGet("/Bil/Oresund")]
        public int GetPriceBilØresund() 
        {
            BilØreSund bilØreSund = new BilØreSund();

            return bilØreSund.Pris();
        }

        // GET: api/Price
        [HttpGet("/getall")]
        public int GetPriceAll()
        {
            return GetPriceBil();
            return GetPriceBilØresund();

        }



        // GET: api/Price/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Price
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Price/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
