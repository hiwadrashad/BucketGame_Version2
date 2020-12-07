using Bucket_Opdracht_Version2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket_Opdracht_Version2.DBContexts
{
    public class ApplicationDBContext : DbContext
    {
        private static ApplicationDBContext _dbContext;
        public ApplicationDBContext()
        {
        }

        public static ApplicationDBContext GetDbcontext()
        {
            if (_dbContext != null)
            {
                _dbContext = new ApplicationDBContext();
            }
            return _dbContext;
        }

        public DbSet<BucketModel> BucketModels { get; set; }

        public DbSet<ContainerModel> containerModels { get; set; }

        public DbSet<OilBarrelModel> oilBarrelModels { get; set; }

        public DbSet<RainbarrelSmallModel> rainbarrelSmallModels { get; set; }

        public DbSet<RainBarrelMediumModel> rainBarrelMediumModels { get; set; }

        public DbSet<RainBarrelLargeModel> rainBarrelLargeModels { get; set; }


        public static ApplicationDBContext Create()
        {
            return new ApplicationDBContext();
        }
    }
}
