using System.Threading.Tasks;
using TaskManager.ViewModel.Responses;

namespace TaskManager.DataAccess.Queries
{
    public interface ITasksQuery
    {
        Task<TasksResponse> RunAsync();
    }
}
