﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthWind.Entities.ValueObjects;

namespace NorthWind.Entities.Interfaces
{
    public interface IUserActionWriter
    {
        void Write(UserAction action);
    }
}
