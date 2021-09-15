﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace RcaApi.Domain.CQRS
{
    public class CQRSApplication
    {
        public string Id { get; set; }
        public string created { get; set; }
        public string Status { get; set; }
        public string Title { get; set; }
        public string ItemType { get; set; }
        public string InternalStatus { get; set; }
        public string Owner { get; set; }
    }
}
