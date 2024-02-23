using BirdDbManager.Data;
using BirdDbManager.Entities;
using BirdDbManager.Repositories;
using Microsoft.Extensions.Options;
using System.Numerics;

Console.WriteLine("Welcome to BirdBdManager!");
Console.WriteLine("");
Console.WriteLine("This app is aimed to help you storage and manage your ornithological data.");
Console.WriteLine("");
var speciesRepo = new SqlRepository<Species>(new BirdDbManagerDbContext());
Starter();

void Starter()
{
    RunProgram();
}

void RunProgram()
{
    PrintMenu();
    var menuInput = "";

    while (menuInput != null)
    {
        menuInput = Console.ReadLine();

        switch (menuInput.ToLower())
        {
            case "1":
                AddNewBird();
                break;
            case "2":
                RemoveExistingBird();
                break;
            case "3":
                PrintData();
                PrintItemsFromRepository(speciesRepo);
                break;
            case "4":
                OpenLogFile();
                break;
            case "q":
                break;
            default:
                Console.WriteLine("Please choose one of the options from menu");
                continue;
        }
        break;
    }
    Console.WriteLine("Good job, see you next time!");

}

void OpenLogFile()
{
    throw new NotImplementedException();
}

void PrintData()
{
    throw new NotImplementedException();
}

void RemoveExistingBird()
{
    throw new NotImplementedException();
}

void AddNewBird()
{
    throw new NotImplementedException();
}

void PrintMenu()
{
    Console.WriteLine("Please choose one of the following options:");
    Console.WriteLine("1 to add bird observation");
    Console.WriteLine("2 to remove bird observation");
    Console.WriteLine("3 to view all stored data");
    Console.WriteLine("4 to open activity log file");
    Console.WriteLine("Q to quit work");




}


PrintItemsFromRepository(speciesRepo);

static void AddBird(IWriteRepository<Species> speciesRepo)
{
    speciesRepo.Save();
}


static void PrintItemsFromRepository<T>(IReadRepository<T> repository) where T : class, IEntity
{
    var items = repository.GetAll();

    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}

