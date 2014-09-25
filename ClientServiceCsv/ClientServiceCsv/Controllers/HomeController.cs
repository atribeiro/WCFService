using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClientServiceCsv.Models;

namespace ClientServiceCsv.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ServiceReference1.CsvServiceClient client = new ServiceReference1.CsvServiceClient();

            var peopleFromService = client.GetListOfPeople();

            HomeModelList people = new HomeModelList();
            foreach (var item in peopleFromService)
            {
                people.Add(new HomeModel
                {
                    ID = item.ID,
                    Name = item.Name,
                    Email = item.Email,
                    Country = item.Country,
                    Contact = item.Phone
                });
            }

            client.Close();

            return View(people);

        }


        }

    }



