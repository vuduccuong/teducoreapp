using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeduCoreApp.Application.Interfaces;
using TeduCoreApp.Application.ViewModels.TodoList;
using TeduCoreApp.Data.Entities;
using TeduCoreApp.Data.Enums;
using TeduCoreApp.Infrastructure.Interfaces;
using TeduCoreApp.Utilities.Dtos;

namespace TeduCoreApp.Application.Implementation
{
    public class TodoListService : ITodoListService
    {
        private readonly IRepository<TodoList, int> _todoRepository;
        private readonly IUnitOfWork _unitOfWork;

        public TodoListService(IRepository<TodoList, int> todoRepository, IUnitOfWork unitOfWork)
        {
            this._todoRepository = todoRepository;
            _unitOfWork = unitOfWork;
        }

        public void Create(TodoListViewModel todoVm)
        {
            var todo = Mapper.Map<TodoListViewModel, TodoList>(todoVm);
            
            _todoRepository.Add(todo);
        }

        public PagedResult<TodoListViewModel> GetAllPaging(string UserID, int pageIndex, int pageSize)
        {

            var query = _todoRepository.FindAll().Where(x => x.UserID == UserID).OrderBy(y=>y.CreatedDate) ;

            var totalRow = query.Count();
            var data = query.OrderByDescending(x => x.CreatedDate)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ProjectTo<TodoListViewModel>()
                .ToList();
            return new PagedResult<TodoListViewModel>()
            {
                CurrentPage = pageIndex,
                PageSize = pageSize,
                Results = data,
                RowCount = totalRow
            };
        }

        public void Delete(int id)
        {
            var todo = _todoRepository.FindById(id);
            _todoRepository.Remove(todo);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(TodoListViewModel todoVm)
        {
            var todo = Mapper.Map<TodoListViewModel, TodoList>(todoVm);
            
            _todoRepository.Update(todo);
        }

        public void UpdateById(int id, Status status)
        {
           var entity= _todoRepository.FindById(id);
            entity.Status = status;
            _todoRepository.Update(entity);
        }
    }
}
