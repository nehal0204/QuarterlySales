using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuarterlySales.Models.ViewModels
{
    public class TopQuartersByEmployeeViewModel
    {
        public int NumberOfQuartersToShow { get; set; }
        public List<Sales> TopQuarters  { get; set; }
    }
}
