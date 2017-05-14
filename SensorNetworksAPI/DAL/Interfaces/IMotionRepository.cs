using SensorNetworksAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorNetworksAPI.DAL.Interfaces
{

    internal interface IMotionRepository
    {
        List<Motion> GetMotions();
        Motion GetSingleMotion(int id);
        bool InsertMotion(Motion motion);
        bool DeleteMotion(int id);
        bool UpdateMotion(Motion motion);
    }

}
