﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachMeSkills.Kaloska.Homework5.Interfaces;

namespace TeachMeSkills.Kaloska.Homework5.Models
{
    class Rhinoceros : AnimalBase
    {
        public override void Say()
        {
            Console.WriteLine("I have a big horn");
        }
    }
}
