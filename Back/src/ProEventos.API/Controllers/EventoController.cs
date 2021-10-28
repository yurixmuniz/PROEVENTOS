using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController(ILogger<EventoController> logger)
        {

        }

        [HttpGet]
        public List<Evento> Get()
        {
            return new List<Evento>()
            {
                new Evento()
                {
                    EventoId = 1,
                    Local = "Chacara",
                    DataEvento = "11/12/2021",
                    Tema = "Churrasco",
                    QtdPessoas = 10,
                    Lote = "A1",
                    ImageURL = "../teste.img"
                },

                 new Evento()
                {
                    EventoId = 2,
                    Local = "Chacara2",
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    Tema = "Natal",
                    QtdPessoas = 20,
                    Lote = "A3",
                    ImageURL = "../teste.img"
                }
            };
          
        }

        [HttpPost]
        public string Post()
        {
            return "Método Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Agora Put id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Agora Delete id = {id}";
        }
    }
}
