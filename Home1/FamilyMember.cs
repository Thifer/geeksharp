namespace Home1;

public class FamilyMember
{
    public FamilyMember(string fullname, Gender gender,
        FamilyMember? mother = null,
        FamilyMember? father = null,
        FamilyMember? spouse = null,
        params FamilyMember[] child)
    {
        Fullname = fullname;
        Gender = gender;
        Mother = mother;
        Father = father;
        Spouse = spouse;
        Child = child;
    }

    public string Fullname { get; set; }
    public Gender Gender { get; set; }
    public FamilyMember? Mother { get; set; }
    public FamilyMember? Father { get; set; }

    public FamilyMember? Spouse { get; set; }
    public FamilyMember[] Child { get; set; }

    public IEnumerable<FamilyMember?> GetGrandMother()
    {
        yield return Mother?.Mother;
        yield return Father?.Mother;
    }

    public IEnumerable<FamilyMember?> GetGrandFather()
    {
        yield return Mother?.Father;
        yield return Father?.Father;
    }
}