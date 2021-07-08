using System;

namespace Reverse.Infrastructure.Models
{
    public class ConsolidatedReport
    {
        public int ConsolidateReportId { get; set; }
        public DateTime Date { get; set; }
        public decimal Payment { get; set; }
        public decimal Income { get; set; }
    }
}
