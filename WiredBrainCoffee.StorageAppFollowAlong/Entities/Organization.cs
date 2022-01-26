namespace WiredBrainCoffee.StorageAppFollowAlong.Entities
{
    public class Organization
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string Name { get; internal set; }

        public override string ToString() => $"Id : {Id}, FirstName: {FirstName}";
        

    }
}