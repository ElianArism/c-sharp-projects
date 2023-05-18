using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
namespace TodoList
{
    internal static class TodosStoreManagement
    {
        private static string filename = Environment.CurrentDirectory + @"\Todos.json";
        public static List<TodoDTO> todos
        { get; set; }

        private static TableLayoutPanel todosContainerRef; 


        public static void load(TableLayoutPanel todosContainer)
        {
            TodosStoreManagement.todosContainerRef = todosContainer; 
            todos = getItems();
            TodosStoreManagement.todos.ForEach((todosItem) =>
            {
                System.Diagnostics.Debug.WriteLine(todosItem.title);
                TodoCard card = new();
                card.SetTodoValues(todosItem);
                todosContainer.Controls.Add(card);

            });
            todosContainer.Refresh();
        }

        public static void updatePanel()
        {
            todos = getItems();
            TodoDTO newTodo =TodosStoreManagement.todos.Last();
            TodoCard card = new();
            card.SetTodoValues(newTodo);
            todosContainerRef.Controls.Add(card);

            todosContainerRef.Refresh();
        }

        public static async Task addItem(TodoDTO newItem)
        {
            using FileStream fs = new FileStream(filename, FileMode.OpenOrCreate);
            todos.Add(newItem);
            // todos.ForEach(item => System.Diagnostics.Debug.WriteLine(item.title, item.description)); 

            await JsonSerializer.SerializeAsync(fs, todos.ToArray(), new JsonSerializerOptions { WriteIndented = true });
            await fs.DisposeAsync();

            fs.Close();

            updatePanel();  

        }


        public static void removeItem()
        {

        }

        public static void updateItem()
        {

        }

        public static void getItem()
        {

        }
        public static List<TodoDTO> getItems()
        {

            if (File.Exists(filename))
            {
                
                string jsonString = File.ReadAllText(filename);
                System.Diagnostics.Debug.WriteLine(jsonString);
                    List<TodoDTO> todos = JsonSerializer.Deserialize<List<TodoDTO>>(jsonString)!;

                return todos;
            }

            return new List<TodoDTO>();
        }

    }
}
