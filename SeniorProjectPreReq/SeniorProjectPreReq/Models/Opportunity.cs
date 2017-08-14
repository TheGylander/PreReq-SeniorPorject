using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SeniorProjectPreReq.Models
{
    public class Opportunity
    {
        public int ID { get; set; }
        public string Center { get; set; }
        public Volunteer MatchedVolunteer { get; set; }
    }

    public class OpportunityDBContext : DbContext
    {
        public DbSet<Opportunity> Opportunities { get; set; }

    }

    
}