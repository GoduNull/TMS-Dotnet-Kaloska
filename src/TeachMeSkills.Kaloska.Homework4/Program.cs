﻿using System;
using System.Collections.Generic;

namespace TeachMeSkills.Kaloska.Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            var diary = new DiaryManager();
            diary.Show();
            Console.ReadKey();
        }
    }
}
