﻿using System;
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
    public class GetCatalogueByCodeQuery
    {
        string connectionString = ConnectionString.CName;

        private readonly RcaApiBase.Model.Map.Map _map;
        public GetCatalogueByCodeQuery()
        {
            _map = new RcaApiBase.Model.Map.Map();
        }

        public IEnumerable<Quipu.RcaApiBase.OpenApi.Models.CatalogueItem> GetCatalogueByCodeData(string? code, string? lang)
        {
            List<CQRSCatalogue> lstData = new List<CQRSCatalogue>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM Catalogue WHERE Code= '" + code + "'";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    CQRSCatalogue data = new CQRSCatalogue();
                    data.Code = rdr["Code"].ToString();
                    data.ParentCode = rdr["ParentCode"].ToString();
                    data.IsFavorite = (bool)rdr["IsFavorite"];
                    data.ItemType = (int)rdr["ItemType"];
                    lstData.Add(data);
                }
                con.Close();
            }
            return _map.MapListCatalogue(lstData);
        }
    }
}
