using LoveCalculatorCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoveCalculatorCore.Interfaces
{
    public interface ILoveHelper
    {
        int CalculateLove(string boy, string girl);
        
    }
}
