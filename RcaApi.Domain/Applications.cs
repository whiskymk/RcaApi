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
    
    [Table("Applications")]
    public class Applications
    {
        [Key]
        public string Id { get; set; }
        public string created { get; set; }
        public string Status { get; set; }
        public string Title { get; set; }
        public string ItemType { get; set; }
        public string InternalStatus { get; set; }
        public string Owner { get; set; }

    }
}
