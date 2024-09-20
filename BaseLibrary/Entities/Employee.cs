
namespace BaseLibrary.Entities
{
    public class Employee : BaseEntity
    {
        public string? CivilId { get; set; }
        public string? FileNumber { get; set; }
        public string? FullName { get; set; }
        public string? JobName { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Photo { get; set; }
        public string? Other { get; set; }

        //Relationship
        public GeneralDepartment? GeneralDepartment { get; set; }
        public int GeneralDepartmentId { get; set; }

        public Department? Department { get; set; }
        public int DepartmentId { get; set; }
        
        public Branch? Branch { get; set; }
        public int BranchId { get; set; }
        
        public Town? Town { get; set; }
        public int TownId { get; set; }

    }
}
