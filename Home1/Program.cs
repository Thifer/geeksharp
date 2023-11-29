// See https://aka.ms/new-console-template for more information

using Home1;

var member1 = new FamilyMember("Name 1", Gender.Men);
var member2 = new FamilyMember("Name 2", Gender.Women);
var member3 = new FamilyMember("Name 3", Gender.Men);
var member4 = new FamilyMember("Name 4", Gender.Women);
var member5 = new FamilyMember("Name 5", Gender.Men);
var member6 = new FamilyMember("Name 6", Gender.Women);
var member7 = new FamilyMember("Name 7", Gender.Men);
var member8 = new FamilyMember("Name 8", Gender.Women);
var member9 = new FamilyMember("Name 9", Gender.Men);
var member10 = new FamilyMember("Name 10", Gender.Women);
var member11 = new FamilyMember("Name 11", Gender.Men);
var member12 = new FamilyMember("Name 12", Gender.Women);
var member13 = new FamilyMember("Name 13", Gender.Men);
var member14 = new FamilyMember("Name 14", Gender.Women);
var member15 = new FamilyMember("Name 15", Gender.Men);
var member16 = new FamilyMember("Name 16", Gender.Women);
var member17 = new FamilyMember("Name 17", Gender.Men);
var member18 = new FamilyMember("Name 18", Gender.Women);
var familyMembers = new List<FamilyMember?>
{
    member1,
    member2,
    member3,
    member4,
    member5,
    member6,
    member7,
    member8,
    member9,
    member10,
    member11,
    member12,
    member13,
    member14,
    member15,
    member16
};
for (int i = 0; i < familyMembers.Count - 1; i += 2)
{
    familyMembers[i].Spouse = familyMembers[i + 1];
    familyMembers[i + 1].Spouse = familyMembers[i];
}

member1.Mother = member4;
member1.Father = member3;
member2.Mother = member6;
member2.Father = member5;
member3.Father = member7;
member3.Mother = member8;
member4.Father = member9;
member4.Mother = member10;
member5.Father = member11;
member5.Mother = member12;
member6.Father = member13;
member6.Mother = member14;
member7.Father = member15;
member7.Mother = member16;
member8.Father = member17;
member8.Mother = member18;

foreach (var variable in member1.GetGrandMother())
    Console.Write($"|{variable?.Fullname} бабушка - {variable?.Spouse?.Fullname} дедушка |");

Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine($"|{member1.Father?.Fullname} папа - {member1.Mother?.Fullname} мама|");
Console.WriteLine("---------------------");
Console.WriteLine($"|{member1.Fullname} главгад - {member1.Spouse?.Fullname} жена|");
Console.WriteLine("---------------------");
Console.WriteLine($"|{member1.Spouse?.Father?.Fullname} папа жены - {member1.Spouse?.Mother?.Fullname} мама жены|");
Console.WriteLine("---------------------");
foreach (var variable in member1.Spouse?.GetGrandMother())
    Console.Write($"|{variable?.Fullname} бабушка жены - {variable?.Spouse.Fullname} дедушка жены|");