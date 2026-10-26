using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University3.Classes;

public class Students
{
    [Key]
    public int Id { get; private set; }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    [ForeignKey(nameof(Groups))]
    public int GroupId { get; private set; }

    public Groups Group { get; private set; }

    public int CourseNumber { get; private set; }
    

    public Students(int id, string firstName, string lastName, int groupId,
        int courseNumber)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        GroupId = groupId;
        CourseNumber = courseNumber;
    }
}