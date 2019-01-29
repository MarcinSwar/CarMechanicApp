namespace CarMechanicApp.Migrations
{
    using CarMechanicApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CarMechanicApp.Data.CarMechanicContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CarMechanicApp.Data.CarMechanicContext context)
        {
            context.Clients.AddOrUpdate(
                p => p.LastName,
                new Client
                {
                    FirstName = "Jan",
                    LastName = "Nowak",
                    PhoneNo = "+48601123456",
                    Address = "Warszawa, Koszykowa 86"

                },
                 new Client
                 {
                     FirstName = "Zbigniew",
                     LastName = "Kowalski",
                     PhoneNo = "+48600000123",
                     Address = "Warszawa, Al. Jerozolimskie  1"

                 },
                  new Client
                  {
                      FirstName = "Anna",
                      LastName = "Malinowska",
                      PhoneNo = "512512512",
                      Address = "Pruszków, Kwiatowa 2"

                  }
                );
            context.Mechanics.AddOrUpdate(
                p => p.LastName,
                new Mechanic
                {
                    FirstName = "Zdzis³aw",
                    LastName = "R¹czka",
                    PhoneNo = "692692123",
                    Address = "Wo³omin, Pusta 21",
                    Salary = 5000
                },
                 new Mechanic
                 {
                     FirstName = "Robert",
                     LastName = "Malanowski",
                     Salary = 4000
                 }
                 );
            context.Vehicles.AddOrUpdate(
                p => p.PlateNo,
                new Vehicle
                {
                    PlateNo = "WW12345",
                    Brand = "Fiat",
                    Model = "126p",
                    ClientId = 1
                },
                 new Vehicle
                 {
                     PlateNo = "WA00001",
                     Brand = "Mercedes",
                     Model = "190d",
                     Colour = "Bia³y",
                     Year =1996,
                     ClientId = 2
                 }
                );
            context.ServiceOrders.AddOrUpdate(
                p => p.StartDate,
                new ServiceOrder
                {
                    StartDate = DateTime.Now,
                    MechanicId = 1,
                    VehicleId = 1,
                    Description = "Problemy z uruchomieniem silnika"
                }

                );
        }
    }
}
