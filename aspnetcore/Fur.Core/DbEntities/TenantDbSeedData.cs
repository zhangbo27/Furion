﻿using Fur.DatabaseAccessor.Models.SeedDatas;
using Fur.DatabaseAccessor.MultipleTenants.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Fur.Core.DbEntities
{
    public class TenantDbSeedData : IDbSeedDataOfT<Tenant>
    {
        public IEnumerable<Tenant> HasData(DbContext dbContext)
        {
            return new List<Tenant>()
            {
                new Tenant{ TenantId = Guid.NewGuid(), Name = "默认租户", Host = "localhost:44307", CreatedTime=DateTime.Now, UpdatedTime=DateTime.Now, IsDeleted=false },
                new Tenant{ TenantId = Guid.NewGuid(), Name = "默认租户", Host = "localhost:41529", CreatedTime=DateTime.Now, UpdatedTime=DateTime.Now, IsDeleted=false }
            };
        }
    }
}