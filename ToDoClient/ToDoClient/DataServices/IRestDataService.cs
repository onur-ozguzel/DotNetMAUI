using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoClient.Models;

namespace ToDoClient.DataServices
{
    public interface IRestDataService
    {
        Task<List<ToDo>> GetAllToDosAsync();
        Task AddToDoAsync(ToDo todo);
        Task UpdateToDoAsync(ToDo todo);
        Task DeleteToDoAsync(int id);
    }
}
