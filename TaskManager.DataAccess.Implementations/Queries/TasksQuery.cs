using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TaskManager.DataAccess.Queries;
using TaskManager.ViewModel.Responses;
using TaskManager.DataBase;

namespace TaskManager.DataAccess.Implementations.Queries
{
    public class TasksQuery : ITasksQuery
    {
        private TaskManagerContext _context;

        public TasksQuery(TaskManagerContext context)
        {
            _context = context;
        }

        public Task<TasksResponse> RunAsync()
        {
            throw new NotImplementedException();
        }
    }
}
