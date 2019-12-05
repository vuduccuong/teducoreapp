using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using TeduCoreApp.Application.Interfaces;
using TeduCoreApp.Application.ViewModels.TodoList;
using TeduCoreApp.Data.Enums;
using TeduCoreApp.Services;

namespace TeduCoreApp.Areas.Admin.Controllers
{
    public class TodoListController : BaseController
    {
        private readonly ITodoListService _todoService;
        private readonly IViewRenderServicee _viewRender;

        public TodoListController(ITodoListService todoService, IViewRenderServicee viewRender)
        {
            _todoService = todoService;
            _viewRender = viewRender;
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            try
            {
                _todoService.Delete(id);
                _todoService.Save();
                return Json(new
                {
                    err = false
                });
            }
            catch (Exception)
            {

                return Json(new
                {
                    err = true
                });
            }
             
        }

        [HttpPost]
        public IActionResult UpdateStatus(int id, Status status)
        {
            _todoService.UpdateById(id, status);
            _todoService.Save();
            return new OkObjectResult(id);
        }

        [HttpGet]
        public IActionResult GetTodoListByUser(string userID, int PageIndex, int PageSize)
        {
            var listTodo = _todoService.GetAllPaging(userID, PageIndex, PageSize);
            foreach (var item in listTodo.Results)
            {
                item.BackDate = Utilities.Helpers.TextHelper.GetBackDate(item.CreatedDate);
            }
            return new OkObjectResult(listTodo);
        }

        [HttpPost]
        public IActionResult SaveTodoItem(TodoListViewModel todoVM)
        {
            todoVM.CreatedDate = DateTime.Now;
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            if (todoVM.ID == 0)
            {
                _todoService.Create(todoVM);
            }
            else
            {
                _todoService.Update(todoVM);
            }
            _todoService.Save();
            return new OkObjectResult(todoVM);
        }

    }
}