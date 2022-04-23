namespace CS_1410_Final_Proj_Lib;
using Final_Proj_Lib;

public class Homework : IHomework
{
    public string AssignmentName { get; set; }
    public DateTime DateAdded { get; set; }
    public DateTime DueDate { get; set; }
    public int PointsWorth { get; set; }
    public static string userToDoFile { get; set; }
    public static int counter = 1;
    private IStorageService storageService;

    public static List<Homework> homeworkList = new List<Homework>();

    public Homework(string assignmentName, DateTime dateAdded, DateTime dueDate, int pointsWorth)
    {
        AssignmentName = assignmentName;
        DateAdded = dateAdded;
        DueDate = dueDate;
        PointsWorth = pointsWorth;
    }

    public Homework(IStorageService storageService)
    {
        this.storageService = storageService;
    }

    public Homework()
    {

    }

    public List<Homework> addToDoList(string assignmentName, DateTime dateAdded, DateTime dueDate, int pointsWorth)
    {
        Homework assignment = new Homework(assignmentName, dateAdded, dueDate, pointsWorth);
        homeworkList.Add(assignment);
        return homeworkList;
    }

    public void removeToDoList(int linesRemoved, string userToDoFile)
    {
        int i = 1;
        List<string> toDoList = new List<string>();
        foreach (var lines in File.ReadAllLines(userToDoFile))
        {
            toDoList.Add(lines);
            Console.WriteLine(lines + i);
            i++;
        }
        toDoList.RemoveAt(linesRemoved);
        File.WriteAllLines(userToDoFile, toDoList);
    }

    public static int homeworkCounter = 1;

    public void saveHomework(string userToDoFile)
    {
        using (var writer = new StreamWriter(userToDoFile, true))
        {
            foreach (var line in homeworkList)
            {
                writer.WriteLine(homeworkCounter + "  " + counter);
                homeworkCounter++;
                writer.WriteLine(homeworkCounter + "  Assignment Name:" + this.AssignmentName + ".");
                homeworkCounter++;
                writer.WriteLine(homeworkCounter + "  Date Added:" + this.DateAdded + ".");
                homeworkCounter++;
                writer.WriteLine(homeworkCounter + "  Due Date:" + this.DueDate + ".");
                homeworkCounter++;
                writer.WriteLine(homeworkCounter + "  Points Worth:" + this.PointsWorth + ".");
                homeworkCounter++;
                counter++;
            }
            writer.Close();
            homeworkList.Clear();
        }
    }
}

public class Person : ILivingPerson
{
    public static List<Person> People = new List<Person>();
    private IStorageService storageService;


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

    public string MakePerson(string firstName, string lastName, int password, int id)
    {
        string errorMessage;

        try
        {
            firstName = FirstName;
            lastName = LastName;
            errorMessage = null;
        }
        catch (NameNotLongEnoughException)
        {
            errorMessage = "Your first or last name is not long enough please try again";
        }

        Password = password;
        Id = id;

        return errorMessage;
    }

    public Person()
    {
    }

    public void SavePerson()
    {
        using (var writer = new StreamWriter("people.txt", true))
        {
            foreach (var people in People)
            {
                writer.WriteLine("Firstname:" + this.FirstName);
                writer.WriteLine("Lastname:" + this.LastName);
                writer.WriteLine("Password:" + this.Password);
                writer.WriteLine("Id:" + this.Id);
            }
            writer.Close();
            People.Clear();
        }
    }

    public List<Person> LoadPerson(string textFile)
    {
        foreach (var lines in File.ReadAllLines(textFile))
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