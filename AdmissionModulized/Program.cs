using System;
using static System.Console;
class Admission
{
    static void Main()
    {
        double gpa;
        int testScore;
        string results;
      
        string inputString;
        WriteLine("Enter grade point average ");
        inputString = ReadLine();
        gpa = Convert.ToDouble(inputString);
        WriteLine("Enter test score ");
        inputString = ReadLine();
        testScore = Convert.ToInt32(inputString);

        results = AcceptOrReject(gpa, testScore);

        WriteLine(results);
    }
    public static string AcceptOrReject(double gpa, int testScore)
    {
        const double MINGPA = 3.0;
        const int ADMIN1 = 60, ADMIN2 = 80;
        string results;

        if (gpa >= MINGPA)
            if (testScore >= ADMIN1)
                results = "Accept";
            else
                results = "Reject";
        else
           if (testScore >= ADMIN2)
            results = "Accept";
        else
            results = "Reject";

        return results;
    }
}
