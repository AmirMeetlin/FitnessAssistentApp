﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetlinFitnessAssistent.Classes
{
    class AppData
    {
        public static EF.Entities Context { get; } = new EF.Entities();
    }
}
