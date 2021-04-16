using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class CovidOpeningPlan
    {
        public int CovidOpeningPlanId { get; set; }
        [Required]
        public DateTime OpeningTime { get; set; }
        [Required]
        public String Description { get; set; }
    }
}
