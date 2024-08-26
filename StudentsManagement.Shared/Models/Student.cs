using System.ComponentModel.DataAnnotations;

namespace StudentsManagement.Shared.Models
{
    public class Student
    {

        [Key]
        public int Id {  get; set; }
        public required string FirstName {  get; set; }
        public required string MiddleName {  get; set; }
        public required string LastName {  get; set; }
        public required string EmailAddress {  get; set; }
        public required string Adress {  get; set; }
        public required string PhoneNumber {  get; set; }
        public required string Country {  get; set; }
    }
}
