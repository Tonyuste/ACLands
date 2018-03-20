namespace ACLands.Backend.Models
{
    using Domain;

    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<ACLands.Domain.User> Users { get; set; }
    }
}