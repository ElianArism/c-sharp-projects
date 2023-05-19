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
            if(todos == null)
            {
                todosContainerRef = todosContainer;
                todos = getItems();
            }
            todos.ForEach((todosItem) =>
            {
                TodoCard card = new();
                card.SetTodoValues(todosItem);
                todosContainer.Controls.Add(card);

            });
            todosContainer.Refresh();
        }

        public static void updatePanel()
        {
            todos = getItems();
            TodoDTO newTodo = todos.Last();
            TodoCard card = new();
            card.SetTodoValues(newTodo);
            todosContainerRef.Controls.Add(card);

            todosContainerRef.Refresh();
        }

        public static async Task addItem(TodoDTO newItem)
        {
            using FileStream fs = new FileStream(filename, FileMode.OpenOrCreate);
            newItem.id = todos.Count.ToString(); 
            todos.Add(newItem);
            await JsonSerializer.SerializeAsync(fs, todos.ToArray(), new JsonSerializerOptions { WriteIndented = true });
            await fs.DisposeAsync();
            fs.Close();
            updatePanel();  

        }


        public static async Task removeItem(TodoDTO todo, Control parent)
        {
            int id = 0; 
            for (int i = 0; i < todos.Count; i++)
            {
         
               if(todos[i].id == todo.id)
                {
                    id = i;
                }
            }
            todos.RemoveAt(id);
            File.WriteAllText(filename, string.Empty);
            using FileStream fs = new FileStream(filename, FileMode.Open);
            await JsonSerializer.SerializeAsync(fs, todos.ToArray(), new JsonSerializerOptions { WriteIndented = true });
            await fs.DisposeAsync();
            fs.Close();
            todosContainerRef.Controls.Remove(parent);
            todosContainerRef.Refresh();
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
                    List<TodoDTO> todos = JsonSerializer.Deserialize<List<TodoDTO>>(jsonString)!;
                return todos;
            }

            return new List<TodoDTO>();
        }

    }
}
