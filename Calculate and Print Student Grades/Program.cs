int CurrentAssignment = 5;

int rafiq1 = 95;
int rafiq2 = 92;
int rafiq3 = 82;
int rafiq4 = 88;
int rafiq5 = 78;

int noman1 = 92;
int noman2 = 92;
int noman3 = 81;
int noman4 = 83;
int noman5 = 72;

int haroon1 = 95;
int haroon2 = 92;
int haroon3 = 92;
int haroon4 = 98;
int haroon5 = 78;

int rafiqsum = rafiq1 + rafiq2 + rafiq3 + rafiq4 + rafiq5;
int nomansum = noman1 + noman2 + noman3 + noman4 + noman5;
int haroonsum = haroon1 + haroon2 + haroon3 + haroon4 + haroon5;

decimal rafiqscore = (decimal)rafiqsum / CurrentAssignment;
decimal nomanscore = (decimal)nomansum / CurrentAssignment;
decimal haroonscore = (decimal)haroonsum / CurrentAssignment;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Rafiq:\t\t" + rafiqscore + "\tA");
Console.WriteLine("Noman:\t\t" + nomanscore + "\tA");
Console.WriteLine("Haroon:\t\t" + haroonscore + "\tA+");







