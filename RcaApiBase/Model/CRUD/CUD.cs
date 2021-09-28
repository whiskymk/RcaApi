using Quipu.RcaApiBase.OpenApi.Models;
using RcaApi.EFCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RcaApiBase.Model.CRUD
{
    public class CUD
    {
        private readonly IUnitOfWork _unitOfWork;
        private RcaApiBase.Model.Map.Map _map;

        public CUD(IUnitOfWork unitOfWork, RcaApiBase.Model.Map.Map map)
        {
            _unitOfWork = unitOfWork;
            _map = map;
        }
        public void ApplicationPost(ModelCase modelCase)
        {
            _unitOfWork.Applications.Add(_map.ModelCaseToApplication(modelCase));
            _unitOfWork.Complete();
        }
        public void ReportPost(ModelCase modelCase)
        {
            _unitOfWork.Reports.Add(_map.ModelCaseToReport(modelCase));
            _unitOfWork.Complete();
        }
        public void CatalogueSetFavoriteItemCodePost(string code)
        {
            _unitOfWork.Catalogues.CatalogueSetFavoriteItemCode(code);
            _unitOfWork.Complete();
        }
        public void CatalogueUnSetFavoriteItemCodePost(string code)
        {
            _unitOfWork.Catalogues.CatalogueUnSetFavoriteItemCode(code);
            _unitOfWork.Complete();
        }
    }
}
