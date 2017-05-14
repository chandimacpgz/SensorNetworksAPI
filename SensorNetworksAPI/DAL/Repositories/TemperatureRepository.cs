using SensorNetworksAPI.DAL.Interfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using SensorNetworksAPI.Models;

namespace SensorNetworksAPI.DAL.Repositories
{

    public class TemperatureRepository : ITemperatureRepository
    {
        private readonly IDbConnection _db;

        public TemperatureRepository()
        {
            _db = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }

        public bool DeleteTemperature(int id)
        {
            int rowsAffected = this._db.Execute("Temperature_Delete",
                new { Id = id }, commandType: CommandType.StoredProcedure);

            if (rowsAffected > 0)
            {
                return true;
            }

            return false;
        }
       

        public List<Temperature> GetTemperatures()
        {
            return _db.Query<Temperature>("Temperature_Get", commandType: CommandType.StoredProcedure).ToList();
        }

        public Temperature GetSingleTemperature(int id)
        {
            return _db.Query<Temperature>("Temperature_GetById",
                new
                {
                    Id = id
                }, commandType: CommandType.StoredProcedure).SingleOrDefault();
        }

        public bool InsertTemperature(Temperature temperature)
        {
            int rowsAffected = this._db.Execute("Temperature_Add",
                new
                {
                    Value = temperature.Value,
                    Location = temperature.Location
                }, commandType: CommandType.StoredProcedure);

            if (rowsAffected > 0)
            {
                return true;
            }

            return false;
        }

        public bool UpdateTemperature(Temperature temperature)
        {
            int rowsAffected = this._db.Execute("Temperature_Update",
                new
                {
                    Id = temperature.Id,
                    Value = temperature.Value,
                    Location = temperature.Location
                }, commandType: CommandType.StoredProcedure);

            if (rowsAffected > 0)
            {
                return true;
            }

            return false;
        }
    }
}