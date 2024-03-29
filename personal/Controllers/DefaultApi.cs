/*
 * Biletado services
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: dh@blaimi.de
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using personal.Attributes;
using personal.Models;
using Npgsql;

namespace personal.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class DefaultApiController : ControllerBase
    {
        public string answerStatus = "{\n  \"authors\" : [ \"Simon Stenzel\", \"Stefan Grassold\", \"Bernd Dorer\" ]\n}";
        /// <summary>
        /// returns information about the backend-service and status
        /// </summary>
        /// <response code="200">successful operation</response>
        [HttpGet]
        [Route("/personal/status/")]
        [ValidateModelState]
        [SwaggerOperation("PersonalStatusGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(PersonalStatusGet200Response), description: "successful operation")]
        public virtual IActionResult PersonalStatusGet()
        {
       

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(PersonalStatusGet200Response));
            string exampleJson = null;
            exampleJson = answerStatus; // "{\n  \"authors\" : [ \"Simon Stenzel\", \"Stefan Grassold\", \"Bernd Dorer\" ]\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PersonalStatusGet200Response>(exampleJson)
            : default(PersonalStatusGet200Response);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
