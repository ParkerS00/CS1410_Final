using System;
using System.Collections.Generic;
using CS_1410_Final_Proj_Lib;
using NUnit.Framework;

namespace Final_Proj_Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void PersonObjectContainsProperValues()
    {
        Person User = new Person("Parker", "Swenson", 4560, 1);
        Assert.AreEqual("Parker", User.FirstName);
        Assert.AreEqual("Swenson", User.LastName);
        Assert.AreEqual(4560, User.Password);
        Assert.AreEqual(1, User.Id);
    }

    [Test]
    public void HomeworkObjectContainsProperValues()
    {
        DateTime dateAdded = new DateTime(2022, 4, 10);
        DateTime dateDue = new DateTime(2022, 4, 13);
        Homework assignment = new Homework("Checkin 4", dateAdded, dateDue, 20);
        Assert.AreEqual("Checkin 4", assignment.AssignmentName);
        Assert.AreEqual(dateAdded, assignment.DateAdded);
        Assert.AreEqual(dateDue, assignment.DueDate);
        Assert.AreEqual(20, assignment.PointsWorth);
    }

    [Test]
    public void AddItemToList()
    {
        DateTime dateAdded = new DateTime(2022, 4, 10);
        DateTime dateDue = new DateTime(2022, 4, 13);
        Homework assignment = new Homework("Test", dateAdded, dateDue, 20);
        List<Homework> homeworkList = new List<Homework>();
        homeworkList.Add(assignment);
        Assert.AreEqual(1, homeworkList.Count);
    }

    [Test]
    public void RemoveItemToList()
    {
        DateTime dateAdded = new DateTime(2022, 4, 10);
        DateTime dateDue = new DateTime(2022, 4, 13);
        Homework assignment = new Homework("Test", dateAdded, dateDue, 20);
        List<Homework> homeworkList = new List<Homework>();
        homeworkList.Add(assignment);
        Assert.AreEqual(1, homeworkList.Count);
        homeworkList.Remove(assignment);
        Assert.AreEqual(0, homeworkList.Count);
    }
}