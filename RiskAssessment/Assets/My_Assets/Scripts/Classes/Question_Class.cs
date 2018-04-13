[System.Serializable]
public class Category
{
    public string categoryName;
    public int maxNumPoints;
    public int currentNumPoints;
}

[System.Serializable]
public class Question : Category {

    public string questions;
    public int questionNum;
    public string[] answers;
    public string[] implication;
    public int[] points;
}