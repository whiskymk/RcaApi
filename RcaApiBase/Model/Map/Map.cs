using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quipu.RcaApiBase.OpenApi.Models;
using static Quipu.RcaApiBase.OpenApi.Models.CatalogueItem;

namespace RcaApiBase.Model.Map
{
    public class Map
    {
        public Quipu.RcaApiBase.OpenApi.Models.ModelCase MapApplications(RcaApi.Domain.CQRS.CQRSApplication _)
        {
            var res = new Quipu.RcaApiBase.OpenApi.Models.ModelCase()
            {
                Id = _.Id,
                Created = _.created,
                Status = _.Status,
                Title = _.Title,
                FieldsData = _.FieldsData,
                ItemType = _.ItemType,
                InternalStatus = _.InternalStatus,
                Owner = _.Owner
            };

            return res;
        }

        public Quipu.RcaApiBase.OpenApi.Models.CatalogueItem MapCatalogue(RcaApi.Domain.CQRS.CQRSCatalogue _)
        {
            var res = new Quipu.RcaApiBase.OpenApi.Models.CatalogueItem()
            {
                Code = _.Code,
                ParentCode = _.ParentCode,
                IsFavorite = _.IsFavorite
            };
            if (_.ItemType == (int)ItemTypeEnum.ApplicationEnum)
                res.ItemType = ItemTypeEnum.ApplicationEnum;
            if (_.ItemType == (int)ItemTypeEnum.ReportEnum)
                res.ItemType = ItemTypeEnum.ReportEnum;

            return res;
        }
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
