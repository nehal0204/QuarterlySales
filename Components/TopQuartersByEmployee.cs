using Microsoft.AspNetCore.Mvc;
using QuarterlySales.Models;
using QuarterlySales.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuarterlySales.Components
{
    public class TopQuartersByEmployee : ViewComponent
    {
        private readonly SalesContext _context;

        public TopQuartersByEmployee(SalesContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke(int numberofQuartersToView = 3)
        {
            var viewModel = new TopQuartersByEmployeeViewModel();

            viewModel.NumberOfQuartersToShow = numberofQuartersToView;

            var sales = _context.Sales.OrderByDescending(p => p.Amount)
                .Take(numberofQuartersToView).ToList();
             
          viewModel.TopQuarters = sales;
            return View(viewModel);
        }
    }
}
