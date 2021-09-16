using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RcaApi.Domain
{
    
    [Table("Catalogue")]
    public class Catalogue
    {
        [Key]
        public string Code { get; set; }
        public string ParentCode { get; set; }
        public bool IsFavorite { get; set; }
        public string ItemType { get; set; }

    }
}
