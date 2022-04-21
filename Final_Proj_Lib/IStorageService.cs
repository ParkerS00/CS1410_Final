namespace CS_1410_Final_Proj_Lib;
using Final_Proj_Lib;
public interface IStorageService
{
    public void SaveHomework(List<Homework> homeworkList, string userToDoFile);
    public List<Homework> LoadHomework();
    public void SavePerson(List<Person> People);
    public List<Person> LoadPerson();
}

public class TextFileStorage : IStorageService
{
    Person person = new Person();
    Homework homework = new Homework();
    public List<Homework> LoadHomework()
    {
        List<Homework> homeworkList = new List<Homework>();
        if (File.Exists("UserToDoList.txt"))
        {
            homeworkList = homework.addToDoList(homework.AssignmentName, homework.DateAdded, homework.DueDate, homework.PointsWorth);
        }
        return homeworkList;
    }

    public List<Person> LoadPerson()
    {
        List<Person> People = new List<Person>();
        if (File.Exists("people.txt"))
        {
            People = person.LoadPerson("people.txt");
        }
        return People;
    }

    public void SaveHomework(List<Homework> homeworkList, string userToDoFile)
    {
        if (File.Exists(userToDoFile))
        {
            homework.saveHomework(userToDoFile);
        }
    }

    public void SavePerson(List<Person> People)
    {
        if (File.Exists("people.txt"))
        {
            person.SavePerson();
        }
    }
}

public class TestingStorageService : IStorageService
{
    Person person = new Person();
    Homework homework = new Homework();
    public List<Homework> LoadHomework()
    {
        List<Homework> homeworkList = new List<Homework>();
        if (File.Exists("UserToDoList.txt"))
        {
            homeworkList = homework.addToDoList(homework.AssignmentName, homework.DateAdded, homework.DueDate, homework.PointsWorth);
        }
        return homeworkList;
    }

    public List<Person> LoadPerson()
    {
        List<Person> People = new List<Person>();
        if (File.Exists("testing.txt"))
        {
            People = person.LoadPerson("testing.txt");
        }
        return People;
    }

    public void SaveHomework(List<Homework> homeworkList, string userToDoFile)
    {
        if (File.Exists(userToDoFile))
        {
            homework.saveHomework(userToDoFile);
        }
    }

    public void SavePerson(List<Person> People)
    {
        throw new NotImplementedException();
    }
}
