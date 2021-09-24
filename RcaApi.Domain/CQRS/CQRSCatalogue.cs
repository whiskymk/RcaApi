using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RcaApi.Domain.CQRS
{
    public class CQRSCatalogue
    {
        public string Code { get; set; }
        public string ParentCode { get; set; }
        public int IsFavorite { get; set; }
        public string ItemType { get; set; }
    }
}
