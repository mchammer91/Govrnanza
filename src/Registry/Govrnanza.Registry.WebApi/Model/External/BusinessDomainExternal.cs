﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Govrnanza.Registry.WebApi.Model.External
{
    public class BusinessDomainExternal
    {
        public string Name { get; set; }
        public List<BusinessSubDomainExternal> SubDomains { get; set; }
    }
}
