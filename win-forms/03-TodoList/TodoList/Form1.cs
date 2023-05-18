namespace TodoList
{
    public partial class TodoListContainer : Form
    {
        public TodoListContainer()
        {
            InitializeComponent();
        }

        private void addTodoBtn_Click(object sender, EventArgs e)
        {
            AddTodoForm addTodoForm = new AddTodoForm();
            addTodoForm.Show(); 
        }

        private void TodoListContainer_Load(object sender, EventArgs e)
        {
            TodosStoreManagement.load(todosContainer);

            

        }

     
    }
}