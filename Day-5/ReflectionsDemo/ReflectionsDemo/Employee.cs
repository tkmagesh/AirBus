namespace ReflectionsDemo
{
    public class Employee
    {
        public int Id { get; set; }
        
        [DisplayName("FName")]
        public string FirstName { get; set; }
        
        [DisplayName("LName")]
        public string LastName { get; set; }

        public decimal Salary { get; set; }
    }
}