using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Sakov.Lab7_8
{
    public class Task : ICommand
    {
        public DateTime DateTimeTask { get; private set; }
        public string Periodicity { get; private set; }
        public int Priority { get; private set; }
        public string Name { get; private set; }
        public string Category { get; private set; }
        public string Status { get; private set; }

        public Task(DateTime date,string period, int priority,string name, string category, string status)
        {
            DateTimeTask = date;
            Periodicity = period;
            Priority = priority;
            Name = name;
            Category = category;
            Status = status;
        }

        public event EventHandler CanExecuteChanged;

        public override string ToString()
        { 
        return $"Название:{Name},\n Приоритет:{Priority},\n Периодичность:{Periodicity},\n Категория:{Category},\n Статус:{Status},\n Дата:{DateTimeTask}.\n";
        }

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
