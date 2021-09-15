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
    public class GetAllApplicationsQuery
    {
        string connectionString = ConnectionString.CName;

        public IEnumerable<CQRSApplication> GetAllApplications()
        {
            List<CQRSApplication> lstData = new List<CQRSApplication>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Select * from Applications", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    CQRSApplication data = new CQRSApplication();
                    data.Id = rdr["id"].ToString();
                    data.InternalStatus = rdr["InternalStatus"].ToString();
                    data.ItemType= rdr["ItemType"].ToString();
                    data.Owner= rdr["Owner"].ToString();
                    data.Status= rdr["Status"].ToString();
                    data.Title = rdr["Title"].ToString();
                    data.created = rdr["created"].ToString();


                    lstData.Add(data);
                }
                con.Close();
            }
            return lstData;
        }
    }
}
