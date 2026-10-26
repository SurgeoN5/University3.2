using System.ComponentModel.DataAnnotations;

namespace University3.Classes;

public class Groups
{
    [Key]
    public int Id { get; private set; }
    public string Name { get; private set; }
    
    public Groups(int id, string name)
    {
        Id = id;
        Name = name;    
    }
}