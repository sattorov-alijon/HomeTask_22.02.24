using Tasc4;
var country1=new Country("Tojikiston","Dushanbe",10000000,"Tajik");

System.Console.WriteLine($"Country Name: {country1.GetName()}\nCapital: {country1.GetCapital()}\nPopulation: {country1.GetPopulation()}\nOfficial Language: {country1.GetOfficialLanguage()}");

System.Console.WriteLine();
country1.SetName("Russia");
country1.SetCapital("Moscow");
country1.SetPopulation(146447424);
country1.SetOfficialLanguage("Rus");


System.Console.WriteLine($"Country Name: {country1.GetName()}\nCapital: {country1.GetCapital()}\nPopulation: {country1.GetPopulation()}\nOfficial Language: {country1.GetOfficialLanguage()}");
