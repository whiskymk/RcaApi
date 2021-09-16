
using Microsoft.AspNetCore.Http;
using RcaApiBase.Model.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RcaApiBase.Model.ParamApi
{
    public class Loader
    {
        private readonly ParameterizationStore.Client.Api.IDefaultApi _defaultApi;
        public Loader(ParameterizationStore.Client.Api.IDefaultApi defaultApi)
        {
            this._defaultApi = defaultApi;
        }
        public Quipu.RcaApiBase.OpenApi.Models.FieldsDefinition GetFieldsDefinitionByCode(string code)
        {
            var caseType = _defaultApi.QuipuGmbHParameterizationStore001CaseTypeCodeGet(code);

            return ParamApiMap.Map(caseType.FieldDefinition);
        }
    }
}
