using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetClothesController : ControllerBase
    {
        private readonly List<Clothes> clothes = new List<Clothes>();

        public GetClothesController()
        {
            clothes.Add(new Clothes()
            {
                ItemId = 1,
                ItemName = "Shirt",
                Size="S/M//L/XL",
                Price = 400
            }) ;
            clothes.Add(new Clothes()
            {
                ItemId = 2,
                ItemName = "Saree",
                Size = "S/M//L/XL",
                Price = 1200
            });
            clothes.Add(new Clothes()
            {
                ItemId = 3,
                ItemName = "Trouser",
                Size = "S/M//L/XL",
                Price = 800
            });
            clothes.Add(new Clothes()
            {
                ItemId = 4,
                ItemName = "Jeans",
                Size = "S/M//L/XL",
                Price = 1500
            });

        }
           
        
        // GET: api/<GetClothesController>
        [HttpGet]
        public IEnumerable<Clothes> Get()
        {
        return clothes;
        }

        // GET api/<GetClothesController>/5
        [HttpGet("{id}")]
        public Clothes Get(int id)
        {
            return clothes.Where(x => x.ItemId == id).FirstOrDefault();
        }
    }
}
