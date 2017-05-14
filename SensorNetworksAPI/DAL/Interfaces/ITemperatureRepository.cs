using SensorNetworksAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorNetworksAPI.DAL.Interfaces
{
    interface ITemperatureRepository
    {
        List<Temperature> GetTemperatures();
        Temperature GetSingleTemperature(int id);
        bool InsertTemperature(Temperature temperature);
        bool DeleteTemperature(int id);
        bool UpdateTemperature(Temperature temperature);
    }
}

