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
    public class DistanceRepository : IDistanceRepository
    {
        private readonly IDbConnection _db;

        public DistanceRepository()
        {
            _db = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }

        public bool DeleteDistance(int id)
        {
            int rowsAffected = this._db.Execute("Distance_Delete",
                new { Id = id }, commandType: CommandType.StoredProcedure);

            if (rowsAffected > 0)
            {
                return true;
            }

            return false;
        }

        public List<Distance> GetDistances()
        {
            return _db.Query<Distance>("Distance_Get", commandType: CommandType.StoredProcedure).ToList();
        }

        //public List<Motion> GetMotions()
        //{
        //    throw new NotImplementedException();
        //}

        public Distance GetSingleDistance(int id)
        {
            return _db.Query<Distance>("Distance_GetById",
                new
                {
                    Id = id
                }, commandType: CommandType.StoredProcedure).SingleOrDefault();
        }

        //public Motion GetSingleMotion(int id)
        //{
        //    throw new NotImplementedException();
        //}

        public bool InsertDistance(Distance distance)
        {
            int rowsAffected = this._db.Execute("Distance_Add",
                new
                {
                    Value = distance.Value,
                    Location = distance.Location
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

        public bool UpdateDistance(Distance distance)
        {
            int rowsAffected = this._db.Execute("Distance_Update",
                new
                {
                    Id = distance.Id,
                    Value = distance.Value,
                    Location = distance.Location
                }, commandType: CommandType.StoredProcedure);

            if (rowsAffected > 0)
            {
                return true;
            }

            return false;
        }
    }
}