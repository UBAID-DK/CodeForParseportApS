using MediatR;
using PlandayApi.Application.Tasks.Dto;


namespace PlandayApi.Application.Tasks.Queries
{
    public class GetTaskByIdQuery: IRequest<TaskDto>
    {
        public int Id { get; set; }
    }
}
