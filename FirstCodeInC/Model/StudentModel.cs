namespace FirstCodeInC.Model;

public class StudentModel(string Enrollment,string Name,int BirthYear)
{
    public string Enrollment { get; } = Enrollment;
    public string Name{get;set;} = Name;
    public int BirthYear{get;} = BirthYear;
    public int Age { get; private set; }

    public void CalculateAge()
    {
        Age = 2025 - BirthYear;
    }

    public bool BirthdayIsValid()
    {
        return BirthYear > 0 && BirthYear <= 2025;
    }
}