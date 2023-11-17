namespace EmployeesCh12.Models
{
    public class DepartmentLocation
    {
        //Composite Primary Key and Foreign key for Department
        public int DepartmentID { get; set; }
        //Composite Primary Key and Foriegn key for Location
        public int LocationID { get; set; }

        //Navigation properties
        public Department Department { get; set; } = null!;
        public Location Location { get; set; } = null!;
    }
}
