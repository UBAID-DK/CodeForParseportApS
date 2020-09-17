using Dapper;
using Microsoft.Extensions.Configuration;
using Planday.Data.Models;
using PlandayApi.Application.Interfaces;
using PlandayApi.Application.Tasks.Dto;
using PlandayApi.Application.Tasks.Queries;
using PlandayApi.Core.ModelView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace PlandayApi.Infrastructure.Repositories
    {
    public class TaskRepository : ITaskRepository
        {
        private readonly IConfiguration _configuration;
        public TaskRepository(IConfiguration configuration)
            {
            _configuration = configuration;
            }


        public async Task<bool> Add(TaskDto taskDto)
            {
            bool OperationStatus = false;
            try
                {
                using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                    {
                    connection.Open();
                    ConnectionState state = connection.State;
                    var sqlexe = "exec [PlandaySchedule] @OperationCommand,@Date,@StartTime ,@EndTIme ,@EmployeeID ,@Status ,@CreatedBy ,@IsCreate,@IsUpdate ,@IsDelete ,@DMLActionDate";
                    var values = new { OperationCommand = "INS", Date = taskDto.Date, StartTime = taskDto.StartTime, EndTIme = taskDto.EndTime, EmployeeID = taskDto.EmployeeId, Status = taskDto.Status, CreatedBy = taskDto.CreatedBy, IsCreate = taskDto.IsCreate, IsUpdate = taskDto.IsUpdate, IsDelete = taskDto.IsDelete, DMLActionDate = taskDto.DmlactionDate };
                    var taskViewModels = await connection.QueryAsync<TaskViewModel>(sqlexe, values);
                    connection.Close();
                    OperationStatus = true;


                    }
                }
            catch (Exception ex)
                {
                throw new Exception(ex.Message);
                }
            return OperationStatus;


            }


        public async Task<bool> Update(TaskDto taskDto)
            {
            bool OperationStatus = false;
            try
                {
                using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                    {
                    connection.Open();
                    ConnectionState state = connection.State;
                    var sqlexe = "exec [PlandaySchedule] @OperationCommand,@Date,@Monday ,@Thuesday ,@Wednesday ,@Thursday ,@Friday ,@Saturday ,@Sunday ,@StartTime ,@EndTIme ,@EmployeeID ,@Status ,@CreatedBy ,@IsCreate,@IsUpdate ,@IsDelete ,@DMLActionDate";
                    var values = new { OperationCommand = "UPD", ID = taskDto.Id, Date = taskDto.Date, StartTime = taskDto.StartTime, EndTIme = taskDto.EndTime, EmployeeID = taskDto.EmployeeId, Status = taskDto.Status, CreatedBy = taskDto.CreatedBy, IsCreate = taskDto.IsCreate, IsUpdate = taskDto.IsUpdate, IsDelete = taskDto.IsDelete, DMLActionDate = taskDto.DmlactionDate };
                    var taskViewModels = await connection.QueryAsync(sqlexe, values);
                    connection.Close();
                    OperationStatus = true;


                    }
                }
            catch (Exception ex)
                {
                throw new Exception(ex.Message);
                }
            return OperationStatus;
            }
        public async Task<bool> Delete(int id)
            {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                bool OperationStatus = false;
                try
                    {
                    connection.Open();
                    ConnectionState state = connection.State;
                    var sqlexe = "exec [PlandaySchedule] @OperationCommand";
                    var values = new { OperationCommand = "DEL", ID = id };
                    var taskViewModels = await connection.QueryAsync<TaskViewModel>(sqlexe, values);
                    connection.Close();
                    OperationStatus = true;
                    }
                catch (Exception ex)
                    {
                    throw new Exception(ex.Message);
                    }

                return OperationStatus;
                }
            }
        public async Task<List<TaskDto>> GetAll()
            {
            //var sql = "SELECT [ScheduleID],[EmployeeID],[DepartmentID],[ShiftID] ,[Date],[StartTime],[EndTime] ,[CreatedBy],[IsCreate],[IsUpdate],[IsDelete],[DMLActionDate]  FROM [dbo].[Schedule];";


            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                connection.Open();
                ConnectionState state = connection.State;
                var sqlexe = "exec [PlandaySchedule] @OperationCommand";
                var values = new { OperationCommand = "SEL" };
                var taskViewModels = await connection.QueryAsync<TaskDto>(sqlexe, values);
                connection.Close();
                return taskViewModels.ToList();
                }

            }
        public async Task<List<TaskDto>> GetById(int id)
            {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                try
                    {
                    connection.Open();
                    ConnectionState state = connection.State;
                    var sqlexe = "exec [PlandaySchedule] @OperationCommand";
                    var values = new { OperationCommand = "SBID", ID = id };
                    var taskViewModels = await connection.QueryAsync<TaskDto>(sqlexe, values);
                    connection.Close();
                    return taskViewModels.ToList();
                    }
                catch (Exception ex)
                    {
                    throw new Exception(ex.Message);
                    }


                }
            }


        public async Task<bool> SwiftShift(int fId, int sId)
            {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                bool OperationStatus = false;
                try
                    {
                    connection.Open();
                    ConnectionState state = connection.State;
                    var sqlexe = "exec [PlandaySchedule] @OperationCommand";
                    var values = new { OperationCommand = "SWFT", PrimaryID = fId, SecondryID = sId };
                    var taskViewModels = await connection.QueryAsync<TaskDto>(sqlexe, values);
                    connection.Close();
                    OperationStatus = true;
                    }
                catch (Exception ex)
                    {
                    throw new Exception(ex.Message);
                    }

                return OperationStatus;
                }
            }
        }
    }