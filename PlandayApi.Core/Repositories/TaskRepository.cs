using Dapper;
using Microsoft.Extensions.Configuration;
using PlandayApi.Application.Interfaces;
using PlandayApi.Core.ModelView;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
namespace PlandayApi.Instrastructor.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly IConfiguration _configuration;

        public TaskRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<int> Add(Core.ModelView.TaskViewModel taskViewModel)
        {
            taskViewModel.Date = DateTime.Now;
            var sql = "INSERT INTO Tasks (Name, Description, Status, DueDate, DateCreated) Values (@Name, @Description, @Status, @DueDate, @DateCreated);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var affectedRows = await connection.ExecuteAsync(sql, taskViewModel);
                return affectedRows;
            }
        }

        public Task<int> Add(Task entity)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Delete(int id)
        {
            var sql = "DELETE FROM Tasks WHERE Id = @Id;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var affectedRows = await connection.ExecuteAsync(sql, new { Id = id });
                return affectedRows;
            }
        }

        public async Task<Core.ModelView.TaskViewModel > Get(int id)
        {
            var sql = "SELECT * FROM Tasks WHERE Id = @Id;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Core.ModelView.TaskViewModel>(sql, new { Id = id });
                return result.FirstOrDefault();
            }
        }

        public async Task<IEnumerable<Core.ModelView.TaskViewModel>> GetAll()
        {
            var sql = "SELECT * FROM Tasks;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Core.ModelView.TaskViewModel>(sql);
                return result;
            }
        }

        public Task<Task> Swift(int pEmpId, int sEmpId)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(Core.ModelView.TaskViewModel taskViewModel)
        {
            taskViewModel.Date = DateTime.Now;
            var sql = "UPDATE Tasks SET Name = @Name, Description = @Description, Status = @Status, DueDate = @DueDate, DateModified = @DateModified WHERE Id = @Id;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var affectedRows = await connection.ExecuteAsync(sql, taskViewModel);
                return affectedRows;
            }
        }


    }
}
