
namespace BirdDbManager.Entities
{
    public class Species : EntityBase
    {
        public string? SpeciesName { get; set; }

        public int number { get; set; }

        public override string ToString() => $"Id: {Id}, SpeciesName: {SpeciesName}, Number: {number}";
        
    }
}
