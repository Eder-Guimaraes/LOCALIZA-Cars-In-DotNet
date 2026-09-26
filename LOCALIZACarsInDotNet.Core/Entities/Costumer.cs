namespace LOCALIZACarsInDotNet.Core.Entities;

using Enums;

public class Costumer
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public string CPF { get; set; }
    
    public string CNHnumber { get; set; }
    
    public CNHCategory CNHCategory { get; set; }
    
    public DateTime BirthDate { get; set; }
    
    public string Email { get; set; }
    
    public string? Phone { get; set; }


    public Costumer(int id, string name, string cpf, string cnHnumber, CNHCategory cnhCategory, DateTime birthDate, string email, string? phone)
    {
        Id = id;
        Name = name;
        CPF = cpf;
        CNHnumber = cnHnumber;
        CNHCategory = cnhCategory;
        BirthDate = birthDate;
        Email = email;
        Phone = phone;
    }
}