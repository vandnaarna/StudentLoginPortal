namespace StudentLoginPortal.Models;

public partial class StudentHobby
{
    public int Hid { get; set; }

    public string Hobby { get; set; } = null!;
        
    public ICollection<StudentDetail>studentDetails { get; set; }   
}
