using SensorNetworksAPI.DAL.Repositories;
using SensorNetworksAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SensorNetworksAPI.Controllers
{
    public class HumidityController : ApiController
    {
        private HumidityRepository _humidityRepository;

        public HumidityController()
        {
            _humidityRepository = new HumidityRepository();
        }

        [Route("Humidity")]
        [HttpGet]
        public List<Humidity> Get()
        {
            return _humidityRepository.GetHumidities();
        }

        [Route("Humidity/{id}")]
        [HttpGet]
        public Humidity Get(int id)
        {
            return _humidityRepository.GetSingleHumidity(id);
        }

        [Route("Humidity")]
        [HttpPost]
        public bool Post([FromBody]Humidity humidity)
        {
            return _humidityRepository.InsertHumidity(humidity);
        }

        [Route("Humidity")]
        [HttpPut]
        public bool Put([FromBody]Humidity humidity)
        {
            return _humidityRepository.UpdateHumidity(humidity);
        }

        [Route("Humidity/{id}")]
        [HttpDelete]
        public bool Delete(int id)
        {
            return _humidityRepository.DeleteHumidity(id);
        }
    }
}
