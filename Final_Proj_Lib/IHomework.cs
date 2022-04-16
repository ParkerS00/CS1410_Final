namespace CS_1410_Final_Proj_Lib;

public interface IHomework
{
    public string AssignmentName { get; set; }
    public DateTime DateAdded { get; set; }
    public DateTime DueDate { get; set; }
    public int PointsWorth { get; set; }
}
