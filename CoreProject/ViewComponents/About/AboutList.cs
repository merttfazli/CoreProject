using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Views.Shared.Components.About
{
    public class AboutList : ViewComponent    
    {
        AboutManager aboutManager = new AboutManager(new EFAboutDal());
        public IViewComponentResult Invoke()
        {
            var values = aboutManager.TGetList();   
            return View(values);
        }
    }
}
