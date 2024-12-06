using System;
using System.Collections.Generic;

namespace StudentLoginPortal.Models;

public partial class StudentDetail
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int? Contact { get; set; }

    public string? Class { get; set; }

    public string Password { get; set; } = null!;

    public int Hid { get; set; }
    

    public StudentHobby studentHobby { get; set; }
}
