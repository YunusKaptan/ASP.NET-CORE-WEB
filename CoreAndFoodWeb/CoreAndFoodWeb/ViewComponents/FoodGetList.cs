using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAndFoodWeb.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoreAndFoodWeb.ViewComponents
{
    public class FoodGetList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            FoodRepository foodRepository = new FoodRepository();
            var foodlist = foodRepository.TList();
            return View(foodlist);
        }
    }
}
