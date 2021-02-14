using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace EF_Core_PostgreSQL
{
    class DB: DbContext
    {

        private readonly string schema;

        public AppDatabase(string schema)
          : base("AppDatabaseConnectionString")
        {
            this.schema = schema;
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.HasDefaultSchema(this.schema);
            base.OnModelCreating(builder);
        }

    }
}
