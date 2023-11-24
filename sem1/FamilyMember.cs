namespace sem1;

public class FamilyMember
{
    private FamilyMember Mom { get; set; }
    private FamilyMember Dad { get; set; }
    private string Name { get; set; }
    private string Surname { get; set; }
    private int Age { get; set; }
    private FamilyMember[] Сhild { get; set; }
    
    private Gender Gender { get; set; }

    public FamilyMember(string name, string surname, int age,Gender gender,FamilyMember mom,FamilyMember dad,params FamilyMember[] child)
    {
        Name = name;
        Surname = surname;
        Age = age;
        Сhild = child;
        Mom = mom;
        Dad = dad;
        Сhild = child;
        Gender = gender;
    }

    public IEnumerable<FamilyMember?> GetGrandMother()
    {
        yield return Mom?.Mom;
        yield return Dad?.Mom;
    }
}