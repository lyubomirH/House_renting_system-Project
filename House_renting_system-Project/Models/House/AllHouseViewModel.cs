using House_renting_system_Project.Models.Query;

namespace House_renting_system_Project.Models.House
{
    public class AllHouseViewModel
    {
        public QueryViewModel Query { get; set; }
        public List<HousesViewModel> Houses { get; set; }

    }
}
