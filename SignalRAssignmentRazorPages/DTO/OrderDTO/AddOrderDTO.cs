using SignalRAssignment.DTO.CategoryDTO;

namespace SignalRAssignment.DTO.OrderDTO
{
    public class AddOrderDTO
    {
        public int? CustomerId { get; set; }
        public DateOnly? OrderDate { get; set; }

        public DateOnly? RequiredDate { get; set; }

        public DateOnly? ShippedDate { get; set; }
        public decimal Freight { get; set; }
        public string? ShipAddress { get; set; }

        public IEnumerable<CategoryOrder> Category { get; set; }


    }
}
