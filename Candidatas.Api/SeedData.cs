 using Candidatas.Api.Models;
 using System.Linq;

 namespace Candidatas.Api.Data
 {
     public static class SeedData
     {
         public static void Initialize(CandidatasContext context)
         {
             if (!context.Interessadas.Any())
             {
                 context.Interessadas.AddRange(
                     new Interessada
                     {
                         Id = 1,
                         Nome = "Franciele",
                         Email = "franciele.silveira1603@gmail.com"
                     },
                     new Interessada
                     {
                         Id = 2,
                         Nome = "Elisa",
                         Email = "elisa@email.com"
                     },
                     new Interessada
                     {
                         Id = 3,
                         Nome = "Fernanda",
                         Email = "fernanda@email.com"
                     }
                 );

                 context.SaveChanges();
             }
         }
     }
 }