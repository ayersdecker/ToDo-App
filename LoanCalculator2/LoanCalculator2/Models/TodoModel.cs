using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LoanCalculator2.Models
{
    public partial class TodoModel
    {
        public string Todo { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public DateTime DateTime { get; set; }

        public string GetDate => DateTime.Now.AddDays(1).ToString("MM/dd");
        public string GetTime => DateTime.Now.AddDays(1).ToString("hh:mm tt");

        public TodoModel()
        {
        }
        public TodoModel(string Todo) 
        { 
            this.Todo = Todo;
            DateTime = DateTime.Now;
            Priority = "Low";
        }

        public TodoModel(string Todo, string Description, string Priority)
        {
            this.Todo = Todo;
            this.Description = Description;
            this.Priority = Priority;
            DateTime = DateTime.Now;
        }
        public TodoModel(string Todo, string Description, string Priority, DateTime dateTime)
        {
            this.Todo = Todo;
            this.Description = Description;
            this.Priority = Priority;
            DateTime = dateTime;
        }

        
    }
}
