
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RcaApiBase.Config;
using RcaApiBase.Model.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RcaApiBase.Model.ParamApi
{
    public class Loader
    {
        private readonly ParameterizationStore.Client.Api.IDefaultApi _defaultApi;
        private readonly ApiClientSettings _apiClientSettings;
        public Loader(ParameterizationStore.Client.Api.IDefaultApi defaultApi, ApiClientSettings apiClientSettings)
        {
            this._defaultApi = defaultApi;
            this._apiClientSettings = apiClientSettings;
        }

        public async Task<Quipu.RcaApiBase.OpenApi.Models.FieldsDefinition> GetFieldDefinitionByCodeAsync(string code, string access_token)
        {
            string path = _apiClientSettings.Endpoint.BaseAddress + _apiClientSettings.Endpoint.Path + "Quipu-GmbH/ParameterizationStore/0.0.1/CaseType/" + code;
            //_defaultApi.Configuration.AddApiKey("Authorization", access_token);
            //_defaultApi.Configuration.AddApiKeyPrefix("Authorization", "Bearer");
            _defaultApi.Configuration.AddDefaultHeader("Authorization", "Bearer " + access_token);
            var caseType = _defaultApi.QuipuGmbHParameterizationStore001CaseTypeCodeGet(code);
            using (var client = new HttpClient())
            {
                if(_apiClientSettings.Endpoint.UseJwtAuth)
                    client.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", access_token);

                var response = await (await client.GetAsync(path)).Content.ReadAsStringAsync();

                var casetypeResponse = JsonConvert.DeserializeObject<ParameterizationStore.Client.Model.CaseType>(response);
                return ParamApiMap.Map(casetypeResponse.FieldDefinition);
            }
        }
        public Quipu.RcaApiBase.OpenApi.Models.FieldsDefinition GetFieldsDefinitionByCode(string code)
        {
            var caseType = _defaultApi.QuipuGmbHParameterizationStore001CaseTypeCodeGet(code);

            return ParamApiMap.Map(caseType.FieldDefinition);

        }
    }
}
