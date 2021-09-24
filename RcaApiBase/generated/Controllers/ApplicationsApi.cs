﻿/*
 * Reports, certificates and applications API
 *
 * This is API for part of the customer portal, Reports, certificates and applications
 *
 * OpenAPI spec version: 1.0.0
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
using RcaApiBase.Config;
using RcaApiBase.Model.Map;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Quipu.RcaApiBase.OpenApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class ApplicationsApiController : ControllerBase
    {
        private readonly GetAllApplicationsQuery _getAllApplicationsQuery;
        private readonly GetApplicationByIdQuery _getApplicationByIdQuery;

        private readonly ParameterizationStore.Client.Api.IDefaultApi _defaultApi;
        private readonly ApiClientSettings _apiClientSettings;

        public ApplicationsApiController(GetAllApplicationsQuery getAllApplicationsQuery, GetApplicationByIdQuery getApplicationByIdQuery, 
                        ParameterizationStore.Client.Api.IDefaultApi defaultApi, ApiClientSettings apiClientSettings)
        {
            _getAllApplicationsQuery = getAllApplicationsQuery;
            _getApplicationByIdQuery = getApplicationByIdQuery;

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
        [Route("/Quipu-GmbH/RCAApi/1.0.0/Application/{id}")]
        [ValidateModelState]
        [SwaggerOperation("ApplicationIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(ModelCase), description: "Application type")]
        public virtual IActionResult ApplicationIdGet([FromRoute][Required] string id)
        {
            //  Log.Information($"Calling ApplicationIdGet with {id}");

            if (_apiClientSettings.Endpoint.UseDummyData)
            {
                string currentDirectory = Directory.GetCurrentDirectory();
                string path = "DummyData";
                string fullPath = Path.Combine(currentDirectory, path, "Applications.json");
                StreamReader r = new StreamReader(fullPath);
                string jsonString = r.ReadToEnd();
                if (jsonString != null)
                    return Ok(jsonString);
                else return Ok();
            }
            else
            {
                var res = _getApplicationByIdQuery.GetApplicationByIdData(id);

                if (res != null)
                    return Ok(res);
                else return Ok();
            }
        }

        /// <summary>
        /// Post New Application
        /// </summary>
        /// <param name="body"></param>
        /// <response code="200">ID and status of application</response>
        /// <response code="500">Server Error</response>
        [HttpPost]
        [Route("/Quipu-GmbH/RCAApi/1.0.0/Application")]
        [ValidateModelState]
        [SwaggerOperation("ApplicationPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(CaseSaveResult), description: "ID and status of application")]
        public virtual IActionResult ApplicationPost([FromBody] ModelCase body)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(CaseSaveResult));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500);
            string exampleJson = null;
            exampleJson = "{\n  \"caseId\" : \"caseId\",\n  \"savedStatus\" : \"savedStatus\"\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<CaseSaveResult>(exampleJson)
            : default(CaseSaveResult);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Saves draft
        /// </summary>
        /// <param name="body"></param>
        /// <response code="200">ID of draft application</response>
        /// <response code="500">Server Error</response>
        [HttpPost]
        [Route("/Quipu-GmbH/RCAApi/1.0.0/Application/SaveDraft")]
        [ValidateModelState]
        [SwaggerOperation("ApplicationSaveDraftPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(string), description: "ID of draft application")]
        public virtual IActionResult ApplicationSaveDraftPost([FromBody] ModelCase body)
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
        /// List of applications
        /// </summary>
        /// <remarks>Returns list of applications belong to specified user </remarks>
        /// <response code="200">List of Applications</response>
        /// <response code="500">Server Error</response>
        [HttpGet]
        [Route("/Quipu-GmbH/RCAApi/1.0.0/Applications")]
        [ValidateModelState]
        [SwaggerOperation("ApplicationsGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<ModelCase>), description: "List of Applications")]
        public virtual IActionResult ApplicationsGet()
        {
            //  Log.Information($"Calling ApplicationsGet");

            if (_apiClientSettings.Endpoint.UseDummyData)
            {
                string currentDirectory = Directory.GetCurrentDirectory();
                string path = "DummyData";
                string fullPath = Path.Combine(currentDirectory, path, "Applications.json");
                StreamReader r = new StreamReader(fullPath);
                string jsonString = r.ReadToEnd();
                if (jsonString != null)
                    return Ok(jsonString);
                else return Ok();
            }
            else
            {
                var res = _getAllApplicationsQuery.GetAllApplications();

                if (res != null)
                    return Ok(res);
                else return Ok();
            }
        }
    }
}
