using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentLoginPortal.Models;

public partial class StudentDetail
{
    public int Id { get; set; }
    [Required(ErrorMessage ="FistName is required")]
    [StringLength(15)]
    public string FirstName { get; set; } = null!;
    [Required(ErrorMessage = "LastName is required")]
    [StringLength(15)]
    public string LastName { get; set; } = null!;
    [Required(ErrorMessage = "Cityname is required")]
    [StringLength(20)]
    public string City { get; set; } = null!;
    [Required(ErrorMessage = "email is required")]
    [EmailAddress]
    public string Email { get; set; } = null!;
    [Required]
    [MaxLength(10)]
    public int? Contact { get; set; }
    [Required(ErrorMessage = "Classname is required")]
    [StringLength(10)]
    public string? Class { get; set; }
    [Required(ErrorMessage = "Password is required")]
    [PasswordPropertyText]
    public string Password { get; set; } = null!;
    
    public int Hid { get; set; }
    [ForeignKey("Hid")]
    public  virtual StudentHobby StudentHobbies { get; set; }
}
