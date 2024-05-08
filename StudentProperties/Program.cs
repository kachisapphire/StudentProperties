using StudentProperties;
List<Student> studentdetails = new List<Student>();
studentdetails.Add(new Student() { Id = 101, Age = 10, Name = "Bola Ahmed", Grade = 4 });
studentdetails.Add(new Student() { Id = 102, Age = 13, Name = "Sarah Eben", Grade = 6 });
studentdetails.Add(new Student() { Id = 103, Age = 17, Name = "Biola Adigun", Grade = 8 });
studentdetails.Add(new Student() { Id = 104, Age = 16, Name = "Obi Boy", Grade = 8 });
studentdetails.Add(new Student() { Id = 105, Age = 12, Name = "Grace Favour", Grade = 5 });
studentdetails.Add(new Student() { Id = 106, Age = 13, Name = "Bolaji Cole", Grade = 6 });
studentdetails.Add(new Student() { Id = 107, Age = 9, Name = "Rabiu Boluwatife", Grade = 4 });
studentdetails.Add(new Student() { Id = 108, Age = 14, Name = "Esther James", Grade = 6 });
studentdetails.Add(new Student() { Id = 109, Age = 13, Name = "Okoli Prosper", Grade = 6 });
studentdetails.Add(new Student() { Id = 110, Age = 11, Name = "Amazing Okonkwo", Grade = 4 });

var studentnames = studentdetails.Select(x => x.Name).ToList();
foreach (var name in studentnames)
{
    Console.WriteLine(name);
}

var qualifiedstudents = studentdetails.Where(x => x.Age > 12).Select(x => new { x.Name, x.Id, x.Age });
foreach (var q in qualifiedstudents)
{
    Console.WriteLine(q);
}
Console.ReadKey();