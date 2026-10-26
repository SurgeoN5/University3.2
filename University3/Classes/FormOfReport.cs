using System.ComponentModel.DataAnnotations;

namespace University3.Classes;

public class FormOfReport
{
    [Key]
    public int Id { get; private set; }
    
    public string Name { get; private set; }

    public FormOfReport(int id, string name)
    {
        Id = id;
        Name = name;
    }
}