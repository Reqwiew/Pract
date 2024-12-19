using Faker;
using pract.Models;

namespace pract.Data
{
    public class DataSeeder
    {

        public static void SeedData(PractDbContext db)
        {
            if (!db.services.Any())
            {
                for (int i = 1; i <= 10; i++)
                {
                    Random r = new Random();

                    var service = new Service
                    {
                        NameService = Lorem.Sentence(),
                        Price = (decimal?)r.NextDouble()
                    };
                    db.services.Add(service);
                }
            }
            if (!db.clients.Any())
            {
                for (int j = 1; j <= 10; j++)
                {
                    Random r = new Random();
                    var client = new Client
                    {
                        Name = Name.First(),
                        secondName = Name.Last(),
                        phoneNumber = r.Next(1000, 1000000),
                        Mail = Lorem.Sentence(20) + "@gmail.com"
                    };
                    db.clients.Add(client);
                }
            }
            if (!db.receptionits.Any())
            {

                for (int k = 1; k <= 10; k++)
                {
                    Random r = new Random();
                    var recept = new Receptionit
                    {
                        Name = Name.First(),
                        secondName = Name.Last(),
                        age = r.Next(18, 100),
                        phone = r.Next(1000, 100000)
                    };
                    db.receptionits.Add(recept);
                }
            }
            if (!db.masters.Any())
            {
                for (int d = 1; d <= 10; d++)
                {
                    Random r = new Random();
                    var master = new Master
                    {
                        Name = Name.First(),
                        secondName = Name.Last(),
                        age = r.Next(18, 100),
                        Phonenumber = r.Next(1000, 1000000)

                    };
                    db.masters.Add(master);
                }
            }
            if (!db.acceptTecs.Any())
            {
                for (int n = 0; n <= 10; n++)
                {
                    var tec = new AcceptTec
                    {
                        Description = Lorem.Sentence(10),
                        DateReg = DateTime.Now,
                        title = Lorem.Sentence(20)



                    };
                    db.acceptTecs.Add(tec);
                }
            }
            if (!db.compliteWorks.Any())
            {
                for (int x = 0; x <= 10; x++)
                {
                    Random r = new Random();
                    var compwk = new CompliteWork
                    {
                        Descrition = Lorem.Sentence(10),
                        Price = (decimal?)r.NextDouble()


                    };
                    db.compliteWorks.Add(compwk);
                }
            }
            if (!db.UseChapters.Any())
            {
                for (int z = 0; z <= 10; z++)
                {
                    Random r = new Random();
                    var usechap = new UseChapters
                    {
                        Title = Lorem.Sentence(10),
                        Cost = (decimal)r.NextDouble()

                    };
                    db.UseChapters.Add(usechap);
                }
            }
            db.SaveChanges();

        }
    }
}