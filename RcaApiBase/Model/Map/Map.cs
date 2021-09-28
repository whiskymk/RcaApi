using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RcaApiBase.Model.Map
{
    public class Map
    {
        public RcaApi.Domain.Applications ModelCaseToApplication(Quipu.RcaApiBase.OpenApi.Models.ModelCase _)
        {
            return new RcaApi.Domain.Applications()
            {
                Id = _.Id,
                Created = (DateTime)_.Created,
                InternalStatus = _.InternalStatus,
                ItemType = _.ItemType,
                Owner = _.Owner,
                Status = _.Status,
                Title = _.Title                
            };
        }
        public RcaApi.Domain.Reports ModelCaseToReport(Quipu.RcaApiBase.OpenApi.Models.ModelCase _)
        {
            return new RcaApi.Domain.Reports()
            {
                Id = _.Id,
                Created = (DateTime)_.Created,
                InternalStatus = _.InternalStatus,
                ItemType = _.ItemType,
                Owner = _.Owner,
                Status = _.Status,
                Title = _.Title
            };
        }
    }
}
