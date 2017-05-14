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
    public class DistanceController : ApiController
    {
        private DistanceRepository _distanceRepository;

        public DistanceController()
        {
            _distanceRepository = new DistanceRepository();
        }

        [Route("Distance")]
        [HttpGet]
        public List<Distance> Get()
        {
            return _distanceRepository.GetDistances();
        }

        [Route("Distance/{id}")]
        [HttpGet]
        public Distance Get(int id)
        {
            return _distanceRepository.GetSingleDistance(id);
        }

        [Route("Distance")]
        [HttpPost]
        public bool Post([FromBody]Distance distance)
        {
            return _distanceRepository.InsertDistance(distance);
        }

        [Route("Distance")]
        [HttpPut]
        public bool Put([FromBody]Distance distance)
        {
            return _distanceRepository.UpdateDistance(distance);
        }

        [Route("Distance/{id}")]
        [HttpDelete]
        public bool Delete(int id)
        {
            return _distanceRepository.DeleteDistance(id);
        }
    }
}
