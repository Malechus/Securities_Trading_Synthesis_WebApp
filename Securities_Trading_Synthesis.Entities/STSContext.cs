using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using Securities_Trading_Synthesis.Entities.DataModels;

namespace Securities_Trading_Synthesis.Entities
{
    public class STSContext : DbContext
    {
        public STSContext()
            : base("name=STSConnection")
        {

        }

        public DbSet<Tweet> Tweets { get; set; }
    }
}
