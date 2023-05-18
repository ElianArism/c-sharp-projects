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
    public partial class AddTodoForm : Form
    {
        public AddTodoForm()
        {
            InitializeComponent();
        }
      
        private async void addTodoBtn_Click(object sender, EventArgs e)
        {
            addTodoBtn.Enabled = false;
            TodoDTO newTodo = new TodoDTO(titleInput.Text, descInput.Text);
            await TodosStoreManagement.addItem(newTodo);
            addTodoBtn.Enabled = true;

        }
    }
}
