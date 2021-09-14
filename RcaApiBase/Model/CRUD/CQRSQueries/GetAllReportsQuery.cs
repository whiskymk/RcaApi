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

        public IEnumerable<CQRSCaseType> GetAllCaseType()
        {
            List<CQRSCaseType> lstData = new List<CQRSCaseType>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Select * from CaseType", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    CQRSCaseType data = new CQRSCaseType();
                    data.Code = rdr["Code"].ToString();
                    data.Description = rdr["Description"].ToString();
                    data.FieldDefinition = rdr["FieldDefinition"].ToString();
                    lstData.Add(data);
                }
                con.Close();
            }
            return lstData;
        }
    }
}
