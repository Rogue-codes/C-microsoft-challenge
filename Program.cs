// initialize variables - graded assignments
int examAssignments = 5;

int[] sophiaScores = [90, 86, 87, 98, 100, 94, 90];
int[] andrewScores = [92, 89, 81, 96, 90, 89];
int[] emmaScores = [90, 85, 87, 98, 68, 89, 89];
int[] loganScores = [90, 95, 87, 88, 96, 96];

// Student names
string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan"];

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// Display the Report Header
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");


foreach (string student in studentNames)
{
    string currentStudent = student;
    if (currentStudent == "Sophia")
    {
        studentScores = sophiaScores;
    }
    else if (currentStudent == "Andrew")
    {
        studentScores = andrewScores;

    }
    else if (currentStudent == "Emma")
    {
        studentScores = emmaScores;

    }
    else
    {
        studentScores = loganScores;
    }

    int sumAssignmentScores = 0;

    decimal examScore = 0;
    decimal extraCredits = 0;

    // initialize/reset the calculated average of exam + extra credit scores
    decimal currentStudentGrade = 0;

    int gradedAssignments = 0;

    foreach (int score in studentScores)
    {
        gradedAssignments += 1;
        if (gradedAssignments <= examAssignments)
        {
            sumAssignmentScores += score;
            examScore = (decimal)sumAssignmentScores/examAssignments;
        }
        else
        {
            // add the extra credit points to the sum - bonus points equal to 10% of an exam score
            sumAssignmentScores += score / 10;
        }

    }
    currentStudentGrade = (decimal)sumAssignmentScores / examAssignments;
    extraCredits = currentStudentGrade - examScore;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{student}\t\t{examScore}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t{examScore}({extraCredits} pts)");

}