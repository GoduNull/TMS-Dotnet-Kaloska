using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachMeSkills.Kaloska.Homework4
{
    class Diary
    {
        private readonly DateTime _dateTimeCreate;
        public DateTime dataTimeTask;
        public string Name { get; private set; }
        public string Task { get; private set; }
        public Diary(DateTime dateTime, string name, string task)
        {
            this._dateTimeCreate = DateTime.Now;
            this.dataTimeTask = dateTime;
            this.Name = name;
            this.Task = task;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Название задачи: {Name}");
            Console.WriteLine($"Дата создания: {_dateTimeCreate}");
            Console.WriteLine($"Дата задачи: {_dateTimeCreate}");
            Console.WriteLine($"Описание задачи: {Task}");
        }
    }
}

