using System;
using System.Collections.Generic;
using System.Text;
using TeduCoreApp.Application.ViewModels.TodoList;
using TeduCoreApp.Data.Enums;
using TeduCoreApp.Utilities.Dtos;

namespace TeduCoreApp.Application.Interfaces
{
    public interface ITodoListService
    {
        void Create(TodoListViewModel todoVm);
        void Update(TodoListViewModel todoVm);
        void UpdateById(int id, Status status);
        void Delete(int id);
        PagedResult<TodoListViewModel> GetAllPaging(string UserID, int pageIndex, int pageSize);
        void Save();
    }
}
