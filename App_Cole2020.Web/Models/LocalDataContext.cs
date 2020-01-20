namespace App_Cole2020.Web.Models
{
    using App_Cole2020.Domain.Models;
    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<App_Cole2020.Common.Models.Tutor> Tutors { get; set; }

        public System.Data.Entity.DbSet<App_Cole2020.Common.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<App_Cole2020.Common.Models.Period> Periods { get; set; }

        public System.Data.Entity.DbSet<App_Cole2020.Common.Models.Group> Groups { get; set; }

        public System.Data.Entity.DbSet<App_Cole2020.Common.Models.Debt> Debts { get; set; }

        public System.Data.Entity.DbSet<App_Cole2020.Common.Models.Payment> Payments { get; set; }
    }
}