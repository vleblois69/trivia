﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    interface IDispatchEvent
    {
        void Dispatch<TEvent>(TEvent @event);
    }
}
