﻿using Examination.Shared.Exams;
using Examination.Shared.SeedWork;
using MediatR;
using System.Collections.Generic;

namespace Examination.Application.Queries.V1.Exams.GetAllExams
{
    public class GetAllExamsQuery : IRequest<ApiResult<IEnumerable<ExamDto>>>
    {
        public GetAllExamsQuery()
        {
        }
    }
}
