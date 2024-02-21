using AutoMapper;
using SignalRAssignment.DTO.CategoryDTO;
using SignalRAssignment.DTO.CustomerDTO;
using SignalRAssignment.DTO.OrderDTO;
using SignalRAssignmentRazorPages.Models;

namespace SignalRAssignment.AutoMapperProfile
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Customer, AddCustomerDTO>().ReverseMap();
            CreateMap<Order, AddOrderDTO>().ReverseMap();
            CreateMap<Category, AddCategoryDTO>().ReverseMap();
        }
    }
}
