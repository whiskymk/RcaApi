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
    public class CatalogueApiController : ControllerBase
    {
        private readonly GetCatalogueByTypeQuery _getCatalogueByTypeQuery;

        private readonly ParameterizationStore.Client.Api.IDefaultApi _defaultApi;
        private readonly ApiClientSettings _apiClientSettings;

        public CatalogueApiController(GetCatalogueByTypeQuery getCatalogueByTypeQuery,
                         ParameterizationStore.Client.Api.IDefaultApi defaultApi, ApiClientSettings apiClientSettings)
        {
            _getCatalogueByTypeQuery = getCatalogueByTypeQuery;

            this._defaultApi = defaultApi;
            this._apiClientSettings = apiClientSettings;
        }
        /// <summary>
        /// Localized description
        /// </summary>
        /// <remarks>Get description for given catalogue item in specified language</remarks>
        /// <param name="itemCode"></param>
        /// <param name="lang"></param>
        /// <response code="200">Available Catalogue</response>
        /// <response code="500">Server Error</response>
        [HttpGet]
        [Route("/Quipu-GmbH/RCAApi/1.0.1/Catalogue/Description/{itemCode}/{lang}")]
        [ValidateModelState]
        [SwaggerOperation("CatalogueDescriptionItemCodeLangGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(string), description: "Available Catalogue")]
        public virtual IActionResult CatalogueDescriptionItemCodeLangGet([FromRoute][Required] string itemCode, [FromRoute][Required] string lang)
        {
            //  Log.Information($"Calling CatalogueDescriptionItemCodeLangGet");

            if (_apiClientSettings.Endpoint.UseDummyData)
            {
                string currentDirectory = Directory.GetCurrentDirectory();
                string path = "DummyData";
                string fullPath = Path.Combine(currentDirectory, path, "Catalogue.json");
                StreamReader r = new StreamReader(fullPath);
                string jsonString = r.ReadToEnd();

                CatalogueItem data = JsonConvert.DeserializeObject<CatalogueItem>(jsonString);

                if (data != null)
                    return Ok(data);
                else return Ok();
            }
            else
            {
                var res = _getCatalogueByTypeQuery.GetCatalogueByTypeData(itemCode);

                if (res != null)
                    return Ok(res);
                else return Ok();
            }
        }

        /// <summary>
        /// Set catalogue item as favorite
        /// </summary>
        /// <param name="itemCode"></param>
        /// <response code="200">Success</response>
        /// <response code="500">Server error</response>
        [HttpPost]
        [Route("/Quipu-GmbH/RCAApi/1.0.1/Catalogue/SetFavorite/{itemCode}")]
        [ValidateModelState]
        [SwaggerOperation("CatalogueSetFavoriteItemCodePost")]
        public virtual IActionResult CatalogueSetFavoriteItemCodePost([FromRoute][Required] string itemCode)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Get Catalogue
        /// </summary>
        /// <remarks>return possible types </remarks>
        /// <param name="clientRef"></param>
        /// <param name="type"></param>
        /// <response code="200">Available Catalogue</response>
        /// <response code="500">Server Error</response>
        [HttpGet]
        [Route("/Quipu-GmbH/RCAApi/1.0.1/Catalogue/{clientRef}")]
        [ValidateModelState]
        [SwaggerOperation("CatalogueClientRefGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<CatalogueItem>), description: "Available Catalogue")]
        public virtual IActionResult CatalogueClientRefGet([FromRoute][Required] string clientRef, [FromQuery] string type)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<CatalogueItem>));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500);
            string exampleJson = null;
            exampleJson = "[ {\n  \"catalogueItemType\" : \"Application\",\n  \"code\" : \"code\",\n  \"parentCode\" : \"parentCode\",\n  \"isFavorite\" : true\n}, {\n  \"catalogueItemType\" : \"Application\",\n  \"code\" : \"code\",\n  \"parentCode\" : \"parentCode\",\n  \"isFavorite\" : true\n} ]";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<CatalogueItem>>(exampleJson)
            : default(List<CatalogueItem>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// UnSet catalogue item as favorite
        /// </summary>
        /// <param name="itemCode"></param>
        /// <response code="200">Success</response>
        /// <response code="500">Server error</response>
        [HttpPost]
        [Route("/Quipu-GmbH/RCAApi/1.0.1/Catalogue/UnSetFavorite/{itemCode}")]
        [ValidateModelState]
        [SwaggerOperation("CatalogueUnSetFavoriteItemCodePost")]
        public virtual IActionResult CatalogueUnSetFavoriteItemCodePost([FromRoute][Required] string itemCode)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500);

            throw new NotImplementedException();
        }
    }
}
