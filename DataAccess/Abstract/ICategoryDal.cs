﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.DataAccess.Abstract
{
    internal interface ICategoryDal
    {
        string Name { get; }
        string Description { get; }
    }
}
