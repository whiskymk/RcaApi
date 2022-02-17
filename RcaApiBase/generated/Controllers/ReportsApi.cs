﻿/*
 * Reports, certificates and applications API
 *
 * This is API for part of the customer portal, Reports, certificates and applications
 *
 * OpenAPI spec version: 1.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Quipu.RcaApiBase.OpenApi.Attributes;
using Microsoft.AspNetCore.Authorization;
using Quipu.RcaApiBase.OpenApi.Models;
using RcaApiBase.Model.CRUD.CQRSQueries;
using RcaApiBase.Model.CRUD;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using RcaApiBase.Config;
using RcaApiBase.Model.Map;
using RcaApi.Domain.CQRS;

namespace Quipu.RcaApiBase.OpenApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class ReportsApiController : ControllerBase
    {
        private readonly GetAllReportsQuery _getAllReportsQuery;
        private readonly GetReportByIdQuery _getReportByIdQuery;

        private readonly ParameterizationStore.Client.Api.IDefaultApi _defaultApi;
        private readonly ApiClientSettings _apiClientSettings;

        public ReportsApiController(GetAllReportsQuery getAllReportsQuery, GetReportByIdQuery getReportByIdQuery,
                            ParameterizationStore.Client.Api.IDefaultApi defaultApi, ApiClientSettings apiClientSettings)
        {
            _getAllReportsQuery = getAllReportsQuery;
            _getReportByIdQuery = getReportByIdQuery;

            this._defaultApi = defaultApi;
            this._apiClientSettings = apiClientSettings;
        }
        /// <summary>
        /// Get application by given id
        /// </summary>
        /// <remarks>return specified application by given id </remarks>
        /// <param name="id"></param>
        /// <response code="200">Application type</response>
        /// <response code="500">Server Error</response>
        [HttpGet]
        [Route("/Quipu-GmbH/RCAApi/1.0.1/Report/{id}")]
        [ValidateModelState]
        [SwaggerOperation("ReportIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(ModelCase), description: "Application type")]
        public virtual IActionResult ReportIdGet([FromRoute][Required] string id)
        {
            //  Log.Information($"Calling ReportIdGet with {id}");

            if (_apiClientSettings.Endpoint.UseDummyData)
            {
                string currentDirectory = Directory.GetCurrentDirectory();
                string path = "DummyData";
                string fullPath = Path.Combine(currentDirectory, path, "Reports.json");
                StreamReader r = new StreamReader(fullPath);
                string jsonString = r.ReadToEnd();

                ModelCase data = JsonConvert.DeserializeObject<ModelCase>(jsonString);

                if (data != null)
                    return Ok(data);
                else return Ok();
            }
            else
            {
                var res = _getReportByIdQuery.GetReportByIdData(id);

                if (res != null)
                    return Ok(res);
                else return Ok();
            }
        }

        /// <summary>
        /// Post new Report request
        /// </summary>
        /// <param name="body"></param>
        /// <response code="200">ID of report request</response>
        /// <response code="500">Server Error</response>
        [HttpPost]
        [Route("/Quipu-GmbH/RCAApi/1.0.1/Report")]
        [ValidateModelState]
        [SwaggerOperation("ReportPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(string), description: "ID of report request")]
        public virtual IActionResult ReportPost([FromBody] ModelCase body)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(string));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500);
            string exampleJson = null;
            exampleJson = "\"\"";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<string>(exampleJson)
            : default(string);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get generated report by given id
        /// </summary>
        /// <remarks>return report result by given id </remarks>
        /// <param name="id"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Result not found</response>
        /// <response code="500">Server Error</response>
        [HttpGet]
        [Route("/Quipu-GmbH/RCAApi/1.0.1/Report/Result/{id}")]
        [ValidateModelState]
        [SwaggerOperation("ReportResultIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(ModelCase), description: "OK")]
        public virtual IActionResult ReportResultIdGet([FromRoute][Required] string id)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ModelCase));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500);
            string exampleJson = null;
            exampleJson = "{\n  \"internalStatus\" : \"internalStatus\",\n  \"owner\" : \"owner\",\n  \"itemType\" : \"itemType\",\n  \"created\" : \"2000-01-23\",\n  \"fieldsData\" : { },\n  \"id\" : \"id\",\n  \"title\" : \"title\",\n  \"status\" : \"status\"\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ModelCase>(exampleJson)
            : default(ModelCase);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// List of reports
        /// </summary>
        /// <remarks>Returns list of reports belong to specified user </remarks>
        /// <param name="clientRef"></param>
        /// <response code="200">List of Reports</response>
        /// <response code="500">Server Error</response>
        [HttpGet]
        [Route("/Quipu-GmbH/RCAApi/1.0.1/Reports/{clientRef}")]
        [ValidateModelState]
        [SwaggerOperation("ReportsGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<ModelCase>), description: "List of Reports")]
        public virtual IActionResult ReportsClientRefGet([FromRoute][Required] string clientRef)
        {
            //  Log.Information($"Calling ReportsGet");

            if (_apiClientSettings.Endpoint.UseDummyData)
            {
                string currentDirectory = Directory.GetCurrentDirectory();
                string path = "DummyData";
                string fullPath = Path.Combine(currentDirectory, path, "Reports.json");
                StreamReader r = new StreamReader(fullPath);
                string jsonString = r.ReadToEnd();

                ModelCase data = JsonConvert.DeserializeObject<ModelCase>(jsonString);

                if (data != null)
                    return Ok(data);
                else return Ok();
            }
            else
            {
                var res = _getAllReportsQuery.GetAllReports();

                if (res != null)
                    return Ok(res);
                else return Ok();
            }
        }
    }
}
