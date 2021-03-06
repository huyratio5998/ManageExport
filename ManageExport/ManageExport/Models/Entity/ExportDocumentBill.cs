﻿
using System;
using System.Collections.Generic;
using System.Text;

namespace ManageExport.Models.Entity
{
    public class ExportDocumentBill : BaseEntity<int>
    {
        public string Code { get; set; }
        public double TotalMoney { get; set; }
        public DateTime ExportDate { get; set; }

        public int SubsidiaryAgentId { get; set; }
        public RatioUser User { get; set; }
        public IEnumerable<ExportListDetail> ExportListDetails { get; set; }
    }
}
