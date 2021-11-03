using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
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
                ItemType = _.ItemType,
                InternalStatus = _.InternalStatus,
                Owner = _.Owner,
                FieldsData = _.FieldsData
            };
        //    FieldsDefinition fd = JsonConvert.DeserializeObject<FieldsDefinition>(_.FieldsData);
        //    res.FieldsData = fd;
            return res;
        }

        public Quipu.RcaApiBase.OpenApi.Models.ModelCase MapReports(RcaApi.Domain.CQRS.CQRSReports _)
        {
            var res = new Quipu.RcaApiBase.OpenApi.Models.ModelCase()
            {
                Id = _.Id,
                Created = _.created,
                Status = _.Status,
                Title = _.Title,
                ItemType = _.ItemType,
                InternalStatus = _.InternalStatus,
                Owner = _.Owner,
                FieldsData = _.FieldsData
            };
        //    FieldsDefinition fd = JsonConvert.DeserializeObject<FieldsDefinition>(_.FieldsData);
        //    res.FieldsData = fd;
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

        public List<Quipu.RcaApiBase.OpenApi.Models.CatalogueItem> MapListCatalogue(List<RcaApi.Domain.CQRS.CQRSCatalogue> CQRScatalogue)
        {
            List<Quipu.RcaApiBase.OpenApi.Models.CatalogueItem> catalogues = new List<Quipu.RcaApiBase.OpenApi.Models.CatalogueItem>();
            CQRScatalogue.ForEach(x => catalogues.Add(MapCatalogue(x)));
            return catalogues;

        }

        public List<Quipu.RcaApiBase.OpenApi.Models.ModelCase> MapListApplications(List<RcaApi.Domain.CQRS.CQRSApplication> CQRSapplications)
        {
            List<Quipu.RcaApiBase.OpenApi.Models.ModelCase> applications = new List<Quipu.RcaApiBase.OpenApi.Models.ModelCase>();
            CQRSapplications.ForEach(x => applications.Add(MapApplications(x)));
            return applications;

        }

        public List<Quipu.RcaApiBase.OpenApi.Models.ModelCase> MapListReports(List<RcaApi.Domain.CQRS.CQRSReports> CQRSreports)
        {
            List<Quipu.RcaApiBase.OpenApi.Models.ModelCase> reports = new List<Quipu.RcaApiBase.OpenApi.Models.ModelCase>();
            CQRSreports.ForEach(x => reports.Add(MapReports(x)));
            return reports;

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
