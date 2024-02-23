namespace BirdDbManager.Entities
{
    public class StudyArea : EntityBase
    {
        public string AreaName {  get; set; }

        public decimal CentralPointLatitude { get; set; }

        public decimal CentralPointLongitude { get; set; }

        public override string ToString() => $"Id: {Id}, AreaName: {AreaName}, Latitude: {CentralPointLatitude},Longitude: {CentralPointLongitude}";

    }
}
