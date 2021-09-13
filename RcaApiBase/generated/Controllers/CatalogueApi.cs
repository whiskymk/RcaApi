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

namespace Quipu.RcaApiBase.OpenApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class CatalogueApiController : ControllerBase
    {
        /// <summary>
        /// Localized description
        /// </summary>
        /// <remarks>Get description for given catalogue item in specified language</remarks>
        /// <param name="itemCode"></param>
        /// <param name="lang"></param>
        /// <response code="200">Available Catalogue</response>
        /// <response code="500">Server Error</response>
        [HttpGet]
        [Route("/Quipu-GmbH/RCAApi/1.0.0/Catalogue/Description/{itemCode}/{lang}")]
        [ValidateModelState]
        [SwaggerOperation("CatalogueDescriptionItemCodeLangGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(string), description: "Available Catalogue")]
        public virtual IActionResult CatalogueDescriptionItemCodeLangGet([FromRoute][Required] string itemCode, [FromRoute][Required] string lang)
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
        /// Set catalogue item as favorite
        /// </summary>
        /// <param name="itemCode"></param>
        /// <response code="200">Success</response>
        /// <response code="500">Server error</response>
        [HttpPost]
        [Route("/Quipu-GmbH/RCAApi/1.0.0/Catalogue/SetFavorite/{itemCode}")]
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
        /// <param name="type"></param>
        /// <response code="200">Available Catalogue</response>
        /// <response code="500">Server Error</response>
        [HttpGet]
        [Route("/Quipu-GmbH/RCAApi/1.0.0/Catalogue/{type}")]
        [ValidateModelState]
        [SwaggerOperation("CatalogueTypeGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<CatalogueItem>), description: "Available Catalogue")]
        public virtual IActionResult CatalogueTypeGet([FromRoute][Required] string type)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<CatalogueItem>));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500);
            string exampleJson = null;
            exampleJson = "[ {\n  \"itemType\" : \"Application\",\n  \"code\" : \"code\",\n  \"parentCode\" : \"parentCode\",\n  \"isFavorite\" : true\n}, {\n  \"itemType\" : \"Application\",\n  \"code\" : \"code\",\n  \"parentCode\" : \"parentCode\",\n  \"isFavorite\" : true\n} ]";

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
        [Route("/Quipu-GmbH/RCAApi/1.0.0/Catalogue/UnSetFavorite/{itemCode}")]
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