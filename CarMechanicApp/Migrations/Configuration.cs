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
                }
                );
        }
    }
}
