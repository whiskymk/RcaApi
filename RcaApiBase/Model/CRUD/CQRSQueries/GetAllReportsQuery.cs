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
    public class GetAllReportsQuery
    {
        string connectionString = ConnectionString.CName;

        public IEnumerable<CQRSReports> GetAllReports()
        {
            List<CQRSReports> lstData = new List<CQRSReports>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Select * from Reports", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    CQRSReports data = new CQRSReports();
                    data.Id = rdr["id"].ToString();
                    data.InternalStatus = rdr["InternalStatus"].ToString();
                    data.ItemType = rdr["ItemType"].ToString();
                    data.Owner = rdr["Owner"].ToString();
                    data.Status = rdr["Status"].ToString();
                    data.Title = rdr["Title"].ToString();
                    data.created = (DateTime)rdr["created"];

                    lstData.Add(data);
                }
                con.Close();
            }
            return lstData;
        }
    }
}
