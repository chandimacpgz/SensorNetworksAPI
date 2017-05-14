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

    public class MotionRepository : IMotionRepository
    {
        private readonly IDbConnection _db;

        public MotionRepository()
        {
            _db = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }

        public bool DeleteMotion(int id)
        {
            int rowsAffected = this._db.Execute("Motion_Delete",
                new { Id = id }, commandType: CommandType.StoredProcedure);

            if (rowsAffected > 0)
            {
                return true;
            }

            return false;
        }

        public List<Motion> GetMotions()
        {
            return _db.Query<Motion>("Motion_Get", commandType: CommandType.StoredProcedure).ToList();
        }

        //public List<Motion> GetMotions()
        //{
        //    throw new NotImplementedException();
        //}

        public Motion GetSingleMotion(int id)
        {
            return _db.Query<Motion>("Motion_GetById",
                new
                {
                    Id = id
                }, commandType: CommandType.StoredProcedure).SingleOrDefault();
        }

        //public Motion GetSingleMotion(int id)
        //{
        //    throw new NotImplementedException();
        //}

        public bool InsertMotion(Motion motion)
        {
            int rowsAffected = this._db.Execute("Motion_Add",
                new
                {
                    Value = motion.Value,
                    Location = motion.Location
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

        public bool UpdateMotion(Motion motion)
        {
            int rowsAffected = this._db.Execute("Motion_Update",
                new
                {
                    Id = motion.Id,
                    Value = motion.Value,
                    Location = motion.Location
                }, commandType: CommandType.StoredProcedure);

            if (rowsAffected > 0)
            {
                return true;
            }

            return false;
        }
    }
}