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
    public static List<Person> People = new List<Person>();


    public Person(string firstName, string lastName, int password, int id)
    {
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

        People.Add(this);
    }

    public void SavePerson()
    {
        using (var writer = new StreamWriter("people.txt"))
        {
            foreach (var people in People)
            {
                writer.WriteLine("Firstname:" + this.FirstName);
                writer.WriteLine("Lastname:" + this.LastName);
                writer.WriteLine("Password:" + this.Password);
                writer.WriteLine("Id:" + this.Id);
            }
            writer.Close();
        }
    }

    public List<Person> LoadPerson()
    {
        foreach (var lines in File.ReadAllLines("people.txt"))
        {
            var parts = lines.Split(':');
            if (parts[0] == "Firstname")
            {
                FirstName = parts[1];
            }
            else if (parts[0] == "Lastname")
            {
                LastName = parts[1];
            }
            else if (parts[0] == "Password")
            {
                Password = int.Parse(parts[1]);
            }
            else if (parts[0] == "Id")
            {
                Id = int.Parse(parts[1]);
            }
            Person User = new Person(FirstName, LastName, Password, Id);
            People.Add(User);
        }
        return People;
    }
}