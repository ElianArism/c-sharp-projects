using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    internal class TodoDTO
    {
        public string title
        { get; set; }

        public string description
        { get; set; }
        public  DateTime creationDate
        { get; set; }

        public  Boolean completed
        { get; set; }

        public TodoDTO(string title, string description)
        {
            this.title = title;
            this.description = description;
            this.creationDate = DateTime.Now;
            this.completed = false;
        }

    }
}
