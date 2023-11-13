// See https://aka.ms/new-console-template for more information

using StudentGrades;

Console.WriteLine("Hello, World!");
var gradeCalculator = new GradeCalculator();

Console.WriteLine("Enter the percentage: ");
int percentage  = Convert.ToInt32(Console.ReadLine());

var grade = gradeCalculator.GetGradeByPercentage(percentage);

//The grade
Console.WriteLine("The Grade: {0}",grade);