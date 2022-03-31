﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMSApplication.Contracts;
using WMSApplication.CustomModels;
using WMSApplication.Data;
using WMSApplication.Models;

namespace WMSApplication.Repositories
{
    public class AuthUserRoleRepository : RepositoryBase<AuthUserRole>, IAuthUserRoleRepository
    {
        public AuthUserRoleRepository(ApplicationContext applicationContext) : base(applicationContext)
        {

        }

        public async Task<IEnumerable<AuthUserRole>> FindAllAsync()
        {
            return await base.FindAll().ToListAsync();
        }
    }
}