﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace entityTest1
{
    public class MyContextFactory : IDbContextFactory<DataContext>
    {
        public DataContext Create() 
        {
            return new DataContext();
        }
    }
}