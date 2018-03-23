using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using VehicleApp;
using VehicleApp.Model;
using VehicleApp.Service;

namespace VehicleApp.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        [Test]
        public void Index()
        {
            VehicleService vehicleService = new VehicleService();

            //Verificar cadastros do Seed
            var result = vehicleService.GetAll();
            Assert.IsNotNull(result);
            var numberOfRecords = result.ToList().Count;
            Assert.AreEqual(1, numberOfRecords);

            //Verificar cadastro de veículo
            VehicleModel model = new VehicleModel
            {
                Brand = "Chevrolet",
                Color = "Preto",
                Model = "Corsa",
                Year = 1999,
                Price = 2000,
                Isnew = false,
                Description = "Chevrolet corsa preto"

            };
            vehicleService.Add(model);

            //Verificar exclusão
            result = vehicleService.GetAll();
            var last = result.Last();
            vehicleService.Remove(last.Id);
            Assert.AreEqual(1, numberOfRecords);
        }

    }
}
