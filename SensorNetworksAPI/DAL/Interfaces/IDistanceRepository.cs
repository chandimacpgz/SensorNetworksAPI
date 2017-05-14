using SensorNetworksAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorNetworksAPI.DAL.Interfaces
{
    interface IDistanceRepository
    {
        List<Distance> GetDistances();
        Distance GetSingleDistance(int id);
        bool InsertDistance(Distance distance);
        bool DeleteDistance(int id);
        bool UpdateDistance(Distance distance);
    }
}

