﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    public interface IDispatchEvent
    {
        void Display(string displayedString);

        void Dispatch<TEvent>(TEvent evenement);
    }
}
