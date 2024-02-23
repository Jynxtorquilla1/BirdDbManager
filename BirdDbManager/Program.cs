using BirdDbManager.Data;
using BirdDbManager.Entities;
using BirdDbManager.Repositories;

var speciesRepo = new SqlRepository<Species>(new BirdDbManagerDbContext());

var observerRepo = new SqlRepository<Observer>(new BirdDbManagerDbContext());

var areaRepo = new SqlRepository<StudyArea>(new BirdDbManagerDbContext());



AddSpecies(speciesRepo);
AddObserver(observerRepo);
AddArea(areaRepo);
PrintItemsFromRepository(speciesRepo);                                
PrintItemsFromRepository<Observer>(observerRepo);
PrintItemsFromRepository<StudyArea>(areaRepo);


static void AddSpecies(IWriteRepository<Species> speciesRepo)
{
    speciesRepo.Add(new Species { SpeciesName = "kaczka", number = 30 });
    speciesRepo.Add(new Species { SpeciesName = "gęś", number = 12 });
    speciesRepo.Add(new Species { SpeciesName = "indyk", number = 2 });
    speciesRepo.Save();
}

static void AddObserver(IWriteRepository<Observer> observerRepo)
{
    observerRepo.Add(new Observer { FirstName = "Grażyna", LastName = "Gwiżdż" });
    observerRepo.Add(new Observer { FirstName = "Janina", LastName = "Świszcz" });
    observerRepo.Add(new Observer { FirstName = "Halina", LastName = "Brzęcz" });
    observerRepo.Save();
}

static void AddArea(IWriteRepository<StudyArea> areaRepo)
{
    areaRepo.Add(new StudyArea { AreaName ="Zalesie", CentralPointLatitude = 51.716144M, CentralPointLongitude = 20.727396M });
    areaRepo.Add(new StudyArea { AreaName = "Zapole", CentralPointLatitude = 51.974058M, CentralPointLongitude = 17.648338M });
    areaRepo.Add(new StudyArea { AreaName = "Zamoście", CentralPointLatitude = 49.836884M, CentralPointLongitude = 20.613858M });
    areaRepo.Save();
} 


static void PrintItemsFromRepository<T>(IReadRepository<T> repository) where T : class, IEntity               
{
    var items = repository.GetAll();

    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}

