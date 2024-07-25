// See https://aka.ms/new-console-template for more information
using PublicArea;

Console.WriteLine("Hello, World!");
Pillar pillar1 = new Pillar();
pillar1.Location = "carmelit";
pillar1.Width = 7;
pillar1.Height = 3;
Console.WriteLine(pillar1.StatusLocation);

Pillar pillar2 = new Pillar();
pillar2.Location = "publicPlace";
pillar2.Width = 5;
pillar2.Height = 8;
Console.WriteLine(pillar2.StatusLocation);

Pillar pillar3 = new Pillar();
pillar3.Location = "privetPlace";
pillar3.Width = 5;
pillar3.Height = 8;
Console.WriteLine(pillar3.StatusLocation);
