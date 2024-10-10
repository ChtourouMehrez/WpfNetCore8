// See https://aka.ms/new-console-template for more information
using SimpleTrader.Domain.Models;
using SimpleTrader.Domain.Services;
using SimpleTrader.EntityFramework;
using SimpleTrader.EntityFramework.Services;
using System.Security.Principal;

Console.WriteLine("Hello, World!");
IDataServise<User> dataServices = new GenericDataService<User>(new SimpleTradeDbContextFactory());
dataServices.Create(new User
{

    Username = "Maysa"
,
    DatedJoined = DateTime.Now,
    Email = "Mehrez-chtourou@outlook.fr",
    Password = "mimihard123A?*"
}).Wait();

//dataServices.Delete(4);
 

Console.WriteLine(dataServices.GetAll().Result.Count().ToString());