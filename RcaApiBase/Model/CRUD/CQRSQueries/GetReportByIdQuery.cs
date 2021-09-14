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
    public class GetReportByIdQuery
    {
        string connectionString = ConnectionString.CName;

        public CQRSCaseTypeFlow GetCaseTypeFlowByIdData(int? id)
        {
            CQRSCaseTypeFlow data = new CQRSCaseTypeFlow();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM CaseTypeFlow WHERE Id= " + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    data.Id = Convert.ToInt32(rdr["Id"]);
                    data.CaseTypeCode = rdr["CaseTypeCode"].ToString();
                    data.SMDefinitionCode = rdr["SMDefinitionCode"].ToString();
                    data.OperationTypeId = Convert.ToInt32(rdr["OperationTypeId"]);
                }
            }
            return data;
        }
    }
}
