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

        public IEnumerable<CQRSCaseTypeFlow> GetAllCaseTypeFlow()
        {
            List<CQRSCaseTypeFlow> lstData = new List<CQRSCaseTypeFlow>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Select * from CaseTypeFlow", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    CQRSCaseTypeFlow data = new CQRSCaseTypeFlow();
                    data.Id = Convert.ToInt32(rdr["Id"]);
                    data.CaseTypeCode = rdr["CaseTypeCode"].ToString();
                    data.SMDefinitionCode = rdr["SMDefinitionCode"].ToString();
                    data.OperationTypeId = Convert.ToInt32(rdr["OperationTypeId"]);

                    lstData.Add(data);
                }
                con.Close();
            }
            return lstData;
        }
    }
}
