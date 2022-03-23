using System.Collections.Generic;
using Examination.Dtos;
using MediatR;

namespace Examination.Application.Queries.V1.Exams.GetHomeExamList
{
    public class GetHomeExamListQuery  : IRequest<IEnumerable<ExamDto>>
    {
        
    }
}