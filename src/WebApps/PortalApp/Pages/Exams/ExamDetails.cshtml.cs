using Examination.Shared.Exams;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PortalApp.Services.Interfaces;
using System.Threading.Tasks;

namespace PortalApp.Pages.Exams
{
    public class ExamDetailsModel : PageModel
    {
        private readonly IExamService _examService;

        [BindProperty]
        public ExamDto Exam { set; get; }

        public ExamDetailsModel(IExamService examService)
        {
            _examService = examService;
        }

        public async Task<IActionResult> OnGet(string id)
        {
            var result = await _examService.GetExamByIdAsync(id);
            if (!result.IsSuccessed)
            {
                return NotFound();
            }

            Exam = result.ResultObj;
            return Page();
        }
    }
}
