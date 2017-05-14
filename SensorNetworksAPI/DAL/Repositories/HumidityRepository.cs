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
    public class HumidityRepository : IHumidityRepository
    {
        private readonly IDbConnection _db;

        public HumidityRepository()
        {
            _db = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }

        public bool DeleteHumidity(int id)
        {
            int rowsAffected = this._db.Execute("Humidity_Delete",
                new { Id = id }, commandType: CommandType.StoredProcedure);

            if (rowsAffected > 0)
            {
                return true;
            }

            return false;
        }

        public List<Humidity> GetHumidities()
        {
            return _db.Query<Humidity>("Humidity_Get", commandType: CommandType.StoredProcedure).ToList();
        }

        //public List<Humidity> GetHumidities()
        //{
        //    throw new NotImplementedException();
        //}

        public Humidity GetSingleHumidity(int id)
        {
            return _db.Query<Humidity>("Humidity_GetById",
                new
                {
                    Id = id
                }, commandType: CommandType.StoredProcedure).SingleOrDefault();
        }

        //public Humidity GetSingleHumidity(int id)
        //{
        //    throw new NotImplementedException();
        //}

        public bool InsertHumidity(Humidity humidity)
        {
            int rowsAffected = this._db.Execute("Humidity_Add",
                new
                {
                    Value = humidity.Value,
                    Location = humidity.Location
                }, commandType: CommandType.StoredProcedure);

            if (rowsAffected > 0)
            {
                return true;
            }

            return false;
        }

        //public bool InsertMotion(Motion motion)
        //{
        //    throw new NotImplementedException();
        //}

        public bool UpdateHumidity(Humidity humidity)
        {
            int rowsAffected = this._db.Execute("Humidity_Update",
                new
                {
                    Id = humidity.Id,
                    Value = humidity.Value,
                    Location = humidity.Location
                }, commandType: CommandType.StoredProcedure);

            if (rowsAffected > 0)
            {
                return true;
            }

            return false;
        }

        //public bool UpdateMotion(Motion motion)
        //{
        //    throw new NotImplementedException();
        //}

    //    public List<Humidity> GetHumidities()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Humidity GetSingleHumidity(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public bool InsertHumidity(Humidity humidity)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public bool DeleteHumidity(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public bool UpdateHumidity(Humidity humidity)
    //    {
    //        throw new NotImplementedException();
    //    }
    }
}