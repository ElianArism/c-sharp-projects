using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoList
{
    internal partial class TodoCard : UserControl
    {
        public TodoDTO todo
        { get; set;  }
        
        public TodoCard()
        {
            InitializeComponent();
        }


        public void SetTodoValues(TodoDTO todo)
        {
            this.todo = todo;

            todoTitle.Text = todo.title;
            dateLabel.Text = todo.creationDate.ToString(); 
        }

        private async void deleteTodo_Click(object sender, EventArgs e)
        {
            Button s = (Button)sender;
            s.Enabled = false; 
            await TodosStoreManagement.removeItem(this.todo, s.Parent);
            s.Enabled = true;
             
            
        }
    }
}
