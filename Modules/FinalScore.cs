// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;
int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;
int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;
int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;
double sophiaFinalScore = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
double nicolasFinalScore = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
double zahirahFinalScore = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
double jeongFinalScore = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;
// Final score:
Console.WriteLine("Final score:");
Console.WriteLine($"Sophia's total score is:{sophiaFinalScore}");
Console.WriteLine($"Nicolas's total score is:{nicolasFinalScore}");
Console.WriteLine($"Zahirah's total score is:{zahirahFinalScore}");
Console.WriteLine($"Jeong's total score is:{jeongFinalScore}");
// Avg Score:
Console.WriteLine("Average Number is: ");
Console.WriteLine("Student\t\tGrade");
Console.WriteLine($"Sophia:\t\t{sophiaFinalScore / currentAssignments} A");
Console.WriteLine($"Nicolas:\t\t{nicolasFinalScore / currentAssignments} B");
Console.WriteLine($"Zahirah:\t\t{zahirahFinalScore / currentAssignments} B");
Console.WriteLine($"Jeong:\t\t{jeongFinalScore / currentAssignments} A");
// Assign letter grades:
Console.WriteLine("Assign letter(Teacher uses): ");
Console.WriteLine("97-100\tA+");
Console.WriteLine("93-96\tA");
Console.WriteLine("90-92\tA-");
Console.WriteLine("87-89\tB+");
Console.WriteLine("83-86\tA+");