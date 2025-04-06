using System.Collections.Generic;

namespace Model;
public class Subdivision
{
    public Subdivision(int id, string name, int? subdivisionId)
    {
        Id = id;
        Name = name;
        SubdivisionId = subdivisionId;
    }

    public int Id { get; set; }
    public string Name { get; set; }

    public int? SubdivisionId { get; set; }
    public List<Subdivision>? Subdivisions { get; set; } = new ();
    public List<User> Users { get; set; } = new ();

    public override string ToString()
    {
        return "Id: " + Id + " " +
            "Name: " + Name + " " +
            "SubdivisionId: " + SubdivisionId;
    }



}