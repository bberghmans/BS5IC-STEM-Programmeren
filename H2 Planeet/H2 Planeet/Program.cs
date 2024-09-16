double gewichtOpAarde = 70.0;

Console.WriteLine("Je weegt op Mercurius " +  gewichtOpAarde*0.38 + " kg.");

double gewichtOpVenus = 0.91 *  gewichtOpAarde;
Console.WriteLine("Je weegt op Venus " + gewichtOpVenus + " kg.");

double factorMars = 0.38;
double gewichtOpMars = factorMars * gewichtOpAarde;
Console.WriteLine("Je weegt op Mars " + gewichtOpMars + " kg.");

string naamJupiter = "Jupiter";
double factorJupiter = 2.34;
double gewichtOpJupiter = factorJupiter * gewichtOpAarde;
Console.WriteLine("Je weegt op " + naamJupiter + " " + gewichtOpMars + " kg.");
