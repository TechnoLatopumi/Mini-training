namespace Classes;

class Student 
{
    public string name;
    public string major;
    public double gpa;

    public Student(string name, string major, double gpa)
    {
        this.name = name;
        this.major = major;
        this.gpa = gpa;
    }

    public bool GoodGpa()
    {
        if(gpa >= 3.0)
        {
            return true;
        }
        else{
            return false;
        }
    }
}