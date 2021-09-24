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
    public class GetCatalogueByTypeQuery
    {
        string connectionString = ConnectionString.CName;

        public CQRSCatalogue GetCatalogueByTypeData(string? type)
        {
            CQRSCatalogue data = new CQRSCatalogue();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM Catalogue WHERE ItemType= '" + type + "'";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    data.Code = rdr["Code"].ToString();
                    data.ParentCode = rdr["ParentCode"].ToString();
                    data.IsFavorite = Convert.ToInt32(rdr["IsFavorite"]);
                    data.ItemType = rdr["ItemType"].ToString();
                }
            }
            return data;
        }
    }
}
