using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TeachMeSkills.Kaloska.Homework4
{
    public class DiaryManager
    {
        List<Diary> diaries = new List<Diary>();
        public void AddTask()
        {
            Console.WriteLine("Введите название задачи");
            var name = Console.ReadLine();
            Console.WriteLine("Введите дату задачи");
            var date = Console.ReadLine();
            Console.WriteLine("Введите описание задачи");
            var task = Console.ReadLine();
            diaries.Add(new Diary(CheckInput(date), name, task));
        }
        public void RemoveTask()
        {
            Console.WriteLine("Введите название задачи для удаления");
            var name = Console.ReadLine();
            diaries.RemoveAll(t => t.Name == name);
        }
        public static DateTime CheckInput(string day)
        {
            DateTime date = new DateTime();
            string reg = @"\d{2}-[0-1]{1}[0-9]{1}-\d{4}";
            if (Regex.IsMatch(day, reg, RegexOptions.IgnoreCase))
            {
                DateTime.TryParse(day, out DateTime dates);
                date = dates;
            }
            else
            {
                Console.WriteLine("Некорректная дата");
            }
            return date;
        }
        public void TaskToday()
        {
            foreach (Diary diary in diaries)
            {
                if (diary.dataTimeTask.Date == DateTime.Now.Date)
                {
                    Console.WriteLine("================================");
                    diary.GetInfo();
                }
            }
        }
        public void SelectTask()
        {
            Console.WriteLine("Введите дату в формате \"00-00-0000\" ");
            var str = Console.ReadLine();
            foreach (Diary diary in diaries)
            {
                if (diary.dataTimeTask.Date == CheckInput(str).Date)
                {
                    diary.GetInfo();
                }
            }
        }
        public void Show()
        {
            Console.WriteLine("Выберите нужное действие:\nДела на сегодня(1)\nВыбрать дату(2)\nДобавить задачу(3)\nУдалить задачу(4)\n");
            string str = Console.ReadLine();
            int.TryParse(str, out int input);
            switch (input)
            {
                case 1:
                    TaskToday();
                    Show();
                    break;
                case 2:
                    SelectTask();
                    Show();
                    break;
                case 3:
                    AddTask();
                    Show();
                    break;
                case 4:
                    RemoveTask();
                    Show();
                    break;
            }
        }
    }

}

