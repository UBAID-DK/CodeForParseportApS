using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Planday.Application.Interfaces;
using Planday.Data.Models;
using PlandayApi.Application.Interfaces;
using PlandayApi.Application.Tasks.Commands;
using PlandayApi.Application.Tasks.Dto;
using PlandayApi.Application.Tasks.Queries;
using PlandayApi.Controllers;
using PlandayApi.Core.ModelView;
using PlandayApi.Infrastructure.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http.Results;

namespace PlandayWebAPi.Controllers
    {
    /// <summary>
    /// this controller taking care of all operation like add, update,delete,return all and so on...
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class PlandayScheduleController : ControllerBase
        {
        IUnitOfWork _unitOfWork;
        public PlandayScheduleController(IUnitOfWork unitOfWork)
            {
            _unitOfWork = unitOfWork;

            }
        /// <summary>
        /// Creating emplyee schedule
        /// </summary>
        /// <param name="taskDto"></param>
        /// <returns>view / show successfully created schedule for employee</returns>
        [HttpPost]
        public async Task<ActionResult<bool>> Create(TaskDto taskDto)
            {
            var result = await _unitOfWork.Tasks.Add(taskDto);
            return result;
            }
        /// <summary>
        /// Get all employee schedule for work
        /// </summary>
        /// <returns>list of all employee</returns>
        [HttpGet]
        public async Task<List<TaskDto>> GetAll()
            {
            var result = await _unitOfWork.Tasks.GetAll();
            return result.ToList();
            }
        /// <summary>
        /// fetch employee / specific employee by employee id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>return single employee / row per employee id</returns>
        [HttpGet("/{id}")]
        public async Task<List<TaskDto>> GetAll(int id)
            {
            var result = await _unitOfWork.Tasks.GetById(id);
            return result.ToList();
            }
        /// <summary>
        /// updating employee data
        /// </summary>
        /// <param name="taskDto"></param>
        /// <returns>show / return updated record</returns>
        [HttpPut]
        public async Task<ActionResult<bool>> Update(TaskDto taskDto)
            {
            var result = await _unitOfWork.Tasks.Update(taskDto);
            return result;
            }
        /// <summary>
        /// updating / exchanging two employee shift / work schedule with each other
        /// </summary>
        /// <param name="fEmployeeId"></param>
        /// <param name="sEmployeeId"></param>
        /// <returns>return updated / exchanged shift of two employee</returns>
        [HttpPut("/{fEmployeeId}/{sEmployeeId}")]
        public async Task<ActionResult<bool>> Update(int fEmployeeId, int sEmployeeId)
            {
            var result = await _unitOfWork.Tasks.SwiftShift(fEmployeeId, sEmployeeId);
            return result;
            }
        /// <summary>
        /// Delete employee schedule / shift
        /// </summary>
        /// <param name="id"></param>
        /// <returns>confirmation that employee shift has been deleted</returns>
        [HttpDelete("/{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
            {
            var result = await _unitOfWork.Tasks.Delete(id);
            return result;
            }

        }
    }

