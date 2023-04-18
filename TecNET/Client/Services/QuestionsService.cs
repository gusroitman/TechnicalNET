using System.Net.Http;
using System.Net;
using System.Text.Json;
using TecNET.Shared.Models;
using System.Net.Http.Json;
using Azure;
using Microsoft.EntityFrameworkCore;
using static MudBlazor.CategoryTypes;

namespace TecNET.Client.Services
{
/*
    public partial class QuestionsService : IQuestionsService
    {
        private readonly HttpClient _httpClient;
        public QuestionsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Questions>> GetAll()
        {
            //return _entries;
            //return await _httpClient.GetFromJsonAsync<Questions[]>("api/questions");
            var response = await _httpClient.GetAsync($"api/questions");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error retrieving knowledge base entry.");
            }

            //var entry = await response.Content.ReadAsStringAsync();
            //var entry = await httpClient.GetFromJsonAsync<List<Element>>("webapi/periodictable");
            var entry = await response.Content.ReadFromJsonAsync<List<Questions>>();
            return entry;
        }

        public async Task<Questions> GetById(int id)
        {
            //return _entries.FirstOrDefault(e => e.Id == id);
            var response = await _httpClient.GetAsync($"api/questions/{id}");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error retrieving knowledge base entry.");
            }

            var entry = await response.Content.ReadFromJsonAsync<Questions>();

            return entry;
        }

        public async Task<Questions> GetByCategory(string category)
        {
            var response = await _httpClient.GetAsync($"api/questions/{category}");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error retrieving knowledge base entry.");
            }

            var entry = await response.Content.ReadFromJsonAsync<Questions>();

            return entry;
        }

        public async Task<List<Questions>> Search(string searchTerm)
        {
            return _entries.Where(e => e.Category.Contains(searchTerm) || e.Title.Contains(searchTerm) || e.Content.Contains(searchTerm)).ToList();
        }

        public async Task Add(Questions entry)
        {
            entry.Id = _entries.Count + 1;
            _entries.Add(entry);
        }

        public async Task Update(int id, Questions entry)
        {
            var existingEntry = await GetById(id);

            if (existingEntry != null)
            {
                existingEntry.Category = entry.Category;
                existingEntry.Title = entry.Title;
                existingEntry.Content = entry.Content;
            }
        }

        public async Task Delete(int id)
        {
            var entry = await GetById(id);

            if (entry != null)
            {
                _entries.Remove(entry);
            }
        }
        
        /*
        private readonly QuestionsDBContext _dbContext;


        public KnowledgeBaseService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<KnowledgeBaseEntry>> GetAll()
        {
            return await _dbContext.KnowledgeBaseEntries.ToListAsync();
        }

        public async Task<KnowledgeBaseEntry> GetById(int id)
        {
            return await _dbContext.KnowledgeBaseEntries.FindAsync(id);
        }

        public async Task<List<KnowledgeBaseEntry>> GetByCategory(string category)
        {
            return await _dbContext.KnowledgeBaseEntries
                .Where(e => e.Category == category)
                .ToListAsync();
        }

        public async Task<List<KnowledgeBaseEntry>> Search(string searchTerm)
        {
            return await _dbContext.KnowledgeBaseEntries
                .Where(e => e.Category.Contains(searchTerm) || e.Question.Contains(searchTerm) || e.Content.Contains(searchTerm))
                .ToListAsync();
        }

        public async Task Add(KnowledgeBaseEntry entry)
        {
            await _dbContext.KnowledgeBaseEntries.AddAsync(entry);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(int id, KnowledgeBaseEntry entry)
        {
            var existingEntry = await _dbContext.KnowledgeBaseEntries.FindAsync(id);

            if (existingEntry != null)
            {
                existingEntry.Category = entry.Category;
                existingEntry.Question = entry.Question;
                existingEntry.Content = entry.Content;

                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task Delete(int id)
        {
            var entry = await _dbContext.KnowledgeBaseEntries.FindAsync(id);

            if (entry != null)
            {
                _dbContext.KnowledgeBaseEntries.Remove(entry);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
        
    }
*/
}
