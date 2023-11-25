class Team
{
    //team name
    //creator name
    //list of team members

    public string Name { get; set; }
    public string Creator { get; set; }
    public List<string> Members { get; set; }

    //constructor, to create new teams (Team objects)
    public Team (string name, string creator) // new empty instance of Team (object)
    {
        Name = name;
        Creator = creator;
        Members = new List<string> ();
    }

    //difference between null and empty
    //
}
