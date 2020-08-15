using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoveCalculatorCore.Models
{
    public class LoveResult
    {
        public int LovePercentage { get; set; }
        public string Lover1 { get; set; }
        public string Lover2 { get; set; }
        public LoveResult(LoveViewModel model)
        {
            this.Lover2 = model.Lover2;
            this.Lover1 = model.Lover1;
        }

    }
   
}
