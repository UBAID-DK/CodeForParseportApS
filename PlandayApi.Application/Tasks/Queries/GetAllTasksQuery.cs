using MediatR;
using PlandayApi.Application.Tasks.Dto;
using System.Collections.Generic;


namespace PlandayApi.Application.Tasks.Queries
{
    public class GetAllTasksQuery: IRequest<List<TaskDto>>
    {
    }
}
