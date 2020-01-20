namespace App_Cole2020.Domain.Models
{
    using System.Data.Entity;
    public class DataContext : DbContext
    {
        public DataContext(): base("DefaultConnection")
        {
        }
    }
}
