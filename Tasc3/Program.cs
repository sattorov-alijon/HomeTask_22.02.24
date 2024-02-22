using Tasc3;

var author=new Author();

author.Name="Alijon";
author.Age=21;
author.Nationality="Tojikiston";

author.Introduce();

author.CelebrateBirthday();

author.Introduce();
System.Console.WriteLine();

var author1=new Author("Alijon",22,"Tojikiston");
author.Introduce();
