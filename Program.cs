// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebJobChollometro.Data;
using WebJobChollometro.Repositories;

string connectionString = "Data Source=spariva.database.windows.net;Initial Catalog=AZURETAJAMAR;Persist Security Info=True;User ID=maki;Password=HotelHazbin27;Encrypt=True;Trust Server Certificate=True";

//dependencias
var provider = new ServiceCollection().AddTransient<RepositoryChollometro>().
    AddDbContext<ChollometroContext>(options => options.UseSqlServer(connectionString)).
    BuildServiceProvider();

RepositoryChollometro repo = provider.GetService<RepositoryChollometro>();

await repo.PopulateAzureAsync();
