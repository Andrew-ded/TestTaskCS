using System.Text.Json.Serialization;

namespace Model;
public class User
{
    public User(int id, string name, string secondName, string fatherland, string job_title, int? subdivisionId)
    {
        Id = id;
        Name = name;
        SecondName = secondName;
        Fatherland = fatherland;
        Job_title = job_title;
        SubdivisionId = subdivisionId;
    }

    public override string ToString()
    {
        return Name +" " + SecondName + " " + Job_title + " " + SubdivisionId;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    
    public string SecondName { get; set; }

    public string Fatherland { get; set; }
    
    public string Job_title { get; set; }

    public int? SubdivisionId { get; set; }

    [JsonIgnore]
    public Subdivision? Subdivision { get; set; }

}