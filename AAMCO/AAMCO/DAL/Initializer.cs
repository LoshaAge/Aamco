using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AAMCO.Models;

namespace AAMCO.DAL
{
    public class Initializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<AAMCOContext>
    {
        protected override void Seed(AAMCOContext context)
        {
            var usersList = new List<StubDataModel>
            {
                new StubDataModel
                {
                    UserId = 1,
                    UserName = "Rami",
                    Company = "Global Solutions"
                },
                new StubDataModel
                {
                    UserId = 1,
                    UserName = "Levi",
                    Company = "Global Solutions"
                },
                new StubDataModel
                {
                    UserId = 1,
                    UserName = "Abc",
                    Company = "Abc Solutions"
                }
            };


            usersList.ForEach(s => context.StubData.Add(s));
            context.SaveChanges();

            
        }
    }
}