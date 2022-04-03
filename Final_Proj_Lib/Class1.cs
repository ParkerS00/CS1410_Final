namespace CS_1410_Final_Proj_Lib;
using Final_Proj_Lib;

public interface IHomework
{
    public string AssignmentName { get; set; }
    public string DateAdded { get; set; }
    public string DateDue { get; set; }
    public int PointsWorth { get; set; }
}

public class Homework : IHomework
{
    public string AssignmentName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string DateAdded { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string DateDue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int PointsWorth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}


public class Person : ILivingPerson
{
    private List<Person> People = new List<Person>();
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Password { get; set; }
    public int Id { get; set; }

    public Person(string firstName, string lastName, int password, int id)
    {
        Person User = new Person(firstName, lastName, password, id);
        if (firstName.Length > 1)
        {
            FirstName = firstName;
        }
        else 
        {
            throw new NameNotLongEnoughException();
        }

        if (lastName.Length > 1)
        {
            LastName = lastName;
        }
        else
        {
            throw new NameNotLongEnoughException();
        }

        Password = password;
        Id = id;

        People.Add(User);
    }
}