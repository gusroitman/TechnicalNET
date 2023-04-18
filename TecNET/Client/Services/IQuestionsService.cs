using TecNET.Shared.Models;

namespace TecNET.Client.Services
{
    public interface IQuestionsService
    {
        Task<List<Questions>> GetAll();
        Task<Questions> GetById(int id);
        Task<Questions> GetByCategory(string category);
        Task<List<Questions>> Search(string searchTerm);
        Task Add(Questions entry);
        Task Update(int id, Questions entry);
        Task Delete(int id);
    }
}