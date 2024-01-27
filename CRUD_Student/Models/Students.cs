namespace CRUD_Student.Models
{

    public class Students
    {
        public int Id { get; set; }
        public string Group { get; set; }
        public string RollNumber { get; set; }
        public string FullName { get; set; }
       

       
        public bool  Absent { get; set; }
        public bool  Present { get; set; }
        public string ? Comment { get; set; }
        public string ? ShowImage { get; set; }
    }
}
