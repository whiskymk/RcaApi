using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Quipu.RcaApiBase.OpenApi.Models.FieldMetaData;
using static Quipu.RcaApiBase.OpenApi.Models.FieldValidator;

namespace RcaApiBase.Model.Map
{
    public static class ParamApiMap
    {
        public static Quipu.RcaApiBase.OpenApi.Models.FieldsDefinition Map(ParameterizationStore.Client.Model.FieldsDefinition _)        
        {
            return new Quipu.RcaApiBase.OpenApi.Models.FieldsDefinition()
            {
                MandatoryFields = MapList(_.MandatoryFields),
                OptionalFields = MapList(_.OptionalFields)
            };
        }
        public static Quipu.RcaApiBase.OpenApi.Models.FieldMetaData Map(ParameterizationStore.Client.Model.FieldMetaData _)
        {
            return new Quipu.RcaApiBase.OpenApi.Models.FieldMetaData()
            {
                DataType = (DataTypeEnum)Enum.ToObject(typeof(DataTypeEnum), (int)_.DataType),
                Description = _.Description,
                FieldGroup = _.FieldGroup,
                FieldLabel = _.FieldLabel,
                FieldName = _.FieldName,
                FieldOrder = _.FieldOrder,
                RefValuesCode = _.RefValuesCode,
                Tags = MapList(_.Tags),
                Validators = MapList(_.Validators)
            };
        }
        public static List<Quipu.RcaApiBase.OpenApi.Models.FieldMetaData> MapList(List<ParameterizationStore.Client.Model.FieldMetaData> _)
        {
            var res = new List<Quipu.RcaApiBase.OpenApi.Models.FieldMetaData>();

            _.ForEach(x => res.Add(Map(x)));

            return res;
        }
        public static List<Quipu.RcaApiBase.OpenApi.Models.Tag> MapList(List<string> _)
        {
            var res = new List<Quipu.RcaApiBase.OpenApi.Models.Tag>();
            _.ForEach(x => res.Add(new Quipu.RcaApiBase.OpenApi.Models.Tag()
            { Code = x, ParentCode = x }));
            return res;
        }
        public static List<Quipu.RcaApiBase.OpenApi.Models.FieldValidator> MapList(List<ParameterizationStore.Client.Model.FieldValidator> _)
        {
            var res = new List<Quipu.RcaApiBase.OpenApi.Models.FieldValidator>();
            _.ForEach(x=> 
                res.Add(new Quipu.RcaApiBase.OpenApi.Models.FieldValidator()
                {
                    Description=x.Description,
                    Message=x.Message,
                    ValidatorEngine= (ValidatorEngineEnum)Enum.ToObject(typeof(ValidatorEngineEnum), (int)x.ValidatorEngine),
                    ValidatorText=x.ValidatorText,
                    ValidatorType= (ValidatorTypeEnum)Enum.ToObject(typeof(ValidatorTypeEnum), (int)x.ValidatorType)

                }));
            return res;
        }
    }
}
