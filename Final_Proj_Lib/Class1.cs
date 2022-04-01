namespace Final_Proj_Lib;

public interface IHomework
{
    public string AssignmentName { get; set; }
    public string DateAdded { get; set; }
    public string DateDue { get; set; }
    public int PointsWorth { get; set; }
}

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Password { get; set; }
    public int Id { get; set; }

    public List<Person> person = new List<Person>();


    public Person LogIn()
    {
        var newUser = new Person();

        try
        {

            if (FirstName.Length > 1 && LastName.Length > 1)
            {
                newUser.FirstName = FirstName;
                newUser.LastName = LastName;
                newUser.Password = Password;
                return newUser;
            }
            else
            {
                throw new NameNotLongEnoughException();
            }
        }
        catch
        {
            throw new NameNotLongEnoughException();
        }
    }

}



public class Homework : IHomework
{
    public string AssignmentName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string DateAdded { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string DateDue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int PointsWorth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}
