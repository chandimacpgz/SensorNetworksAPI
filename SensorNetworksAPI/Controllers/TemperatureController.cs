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
    public class TemperatureController : ApiController
    {
        private TemperatureRepository _temperatureRepository;

        public TemperatureController()
        {
            _temperatureRepository = new TemperatureRepository();
        }

        [Route("Temperature")]
        [HttpGet]
        public List<Temperature> Get()
        {
            return _temperatureRepository.GetTemperatures();
        }

        [Route("Temperature/{id}")]
        [HttpGet]
        public Temperature Get(int id)
        {
            return _temperatureRepository.GetSingleTemperature(id);
        }

        [Route("Temperature")]
        [HttpPost]
        public bool Post([FromBody]Temperature temperature)
        {
            return _temperatureRepository.InsertTemperature(temperature);
        }

        [Route("Temperature")]
        [HttpPut]
        public bool Put([FromBody]Temperature temperature)
        {
            return _temperatureRepository.UpdateTemperature(temperature);
        }

        [Route("Temperature/{id}")]
        [HttpDelete]
        public bool Delete(int id)
        {
            return _temperatureRepository.DeleteTemperature(id);
        }
    }
}
