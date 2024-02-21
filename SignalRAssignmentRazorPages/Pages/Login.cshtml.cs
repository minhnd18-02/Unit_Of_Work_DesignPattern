using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SignalRAssignment.Interface;
using SignalRAssignmentRazorPages.Models;

namespace SignalRAssignmentRazorPages.Pages
{
    public class LoginModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public LoginModel(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        [BindProperty]
        public Account Login { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            await _unitOfWork.AccountRepository.Login(Login);
            await _unitOfWork.CompleteAsync();
            return RedirectToPage("/Customer");
        }    
    }
}
