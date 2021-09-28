using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RcaApi.Domain.CQRS;
using System.Threading;
using RcaApi.EFCore;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace RcaApiBase.Model.CRUD.CQRSQueries
{
    public class GetApplicationByIdQuery
    {
        string connectionString = ConnectionString.CName;
        private readonly RcaApiBase.Model.Map.Map _map;
        public GetApplicationByIdQuery()
        {
            _map = new RcaApiBase.Model.Map.Map();
        }

        public CQRSApplication GetApplicationByIdData(string? id)
        {
            CQRSApplication data = new CQRSApplication();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM Applications WHERE Id= " + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    data.Id = rdr["id"].ToString();
                    data.InternalStatus = rdr["InternalStatus"].ToString();
                    data.ItemType = rdr["ItemType"].ToString();
                    data.Owner = rdr["Owner"].ToString();
                    data.Status = rdr["Status"].ToString();
                    data.Title = rdr["Title"].ToString();
                    data.FieldsData = rdr["FieldsData"].ToString();
                    data.created = (DateTime)rdr["created"];
                }
            }
            return _map.MapApplications(data);
            //return data;
        }
    }
}
