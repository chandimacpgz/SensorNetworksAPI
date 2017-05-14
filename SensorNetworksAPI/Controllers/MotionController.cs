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
    public class MotionController : ApiController
    {
        private MotionRepository _motionRepository;

        public MotionController()
        {
            _motionRepository = new MotionRepository();
        }

        [Route("Motion")]
        [HttpGet]
        public List<Motion> Get()
        {
            return _motionRepository.GetMotions();
        }

        [Route("Motion/{id}")]
        [HttpGet]
        public Motion Get(int id)
        {
            return _motionRepository.GetSingleMotion(id);
        }

        [Route("Motion")]
        [HttpPost]
        public bool Post([FromBody]Motion motion)
        {
            return _motionRepository.InsertMotion(motion);
        }

        [Route("Motion")]
        [HttpPut]
        public bool Put([FromBody]Motion motion)
        {
            return _motionRepository.UpdateMotion(motion);
        }

        [Route("Motion/{id}")]
        [HttpDelete]
        public bool Delete(int id)
        {
            return _motionRepository.DeleteMotion(id);
        }
    }
}
