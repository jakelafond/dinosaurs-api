using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DinosaursAPI.Models;

namespace DinosaursAPI.Controllers
{
    [Route("api/[controller]")]
    public class DinosaursController : Controller
    {
        // GET api/dinosaurs
        [HttpGet]
        public List<DinosaurModel> Get()
        {
            var dino = new DinosaurModel();
            List<DinosaurModel> dinos = dino.GetDinosaurs();
            return dinos;
        }

        // GET api/dinosaurs/5
        [HttpGet("{id}")]
        public DinosaurModel Get(int id)
        {
            var dino = new DinosaurModel();
            List<DinosaurModel> dinos = dino.GetDinosaurs();
            return dinos[id - 1];
        }

        // POST api/dinosaurs
        [HttpPost]
        public List<DinosaurModel> Post([FromBody]string name, string size, string weight, string period, string habitats)
        {
            var dino = new DinosaurModel();
            var listofDinos = dino.GetDinosaurs();
            var newDino = new DinosaurModel
            {
                ID = listofDinos.Count + 1,
                Name = name,
                Size = size,
                Weight = weight,
                Period = period,
                Habitats = habitats
            };
            listofDinos.Add(newDino);
            return listofDinos;
        }

        // PUT api/dinosaurs/5
        [HttpPut("{id}")]
        public List<DinosaurModel> Put(int id, [FromBody]string name, string size, string weight, string period, string habitats)
        {
            var dino = new DinosaurModel();
            var listofDinos = dino.GetDinosaurs();
            if (listofDinos.Any(i => i.ID == id))
            {
                dino = listofDinos.SingleOrDefault(x => x.ID == id);
                dino.Name = name;
                dino.Size = size;
                dino.Weight = weight;
                dino.Period = period;
                dino.Habitats = habitats;
            }
            else
            {
                var newDino = new DinosaurModel
                {
                    ID = listofDinos.Count + 1,
                    Name = name,
                    Size = size,
                    Weight = weight,
                    Period = period,
                    Habitats = habitats
                };
                listofDinos.Add(newDino);
            }

            return listofDinos;
        }

        // DELETE api/dinosaurs/5
        [HttpDelete("{id}")]
        public List<DinosaurModel> Delete(int id)
        {
            var dino = new DinosaurModel();
            var listofDinos = dino.GetDinosaurs();
            dino = listofDinos.SingleOrDefault(i => i.ID == id);
            listofDinos.Remove(dino);
            return listofDinos;

        }
    }
}
