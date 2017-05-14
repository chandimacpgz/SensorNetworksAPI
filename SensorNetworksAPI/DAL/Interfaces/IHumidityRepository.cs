using SensorNetworksAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SensorNetworksAPI.DAL.Interfaces
{
    internal interface IHumidityRepository
    {
        List<Humidity> GetHumidities();
        Humidity GetSingleHumidity(int id);
        bool InsertHumidity(Humidity humidity);
        bool DeleteHumidity(int id);
        bool UpdateHumidity(Humidity humidity);
    }
}