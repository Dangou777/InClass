// See https://aka.ms/new-console-template for more information
using InClass;
using System.Security.Cryptography;
//Dog dog = new Dog() {Name = "buddy"};
//cat cat = new cat() { Name = "kjfdsh" };
//lion lion = new lion { Name = "petel" };
//benia yonatan = new benia() { Name = "yonatan" };
//sayhello(yonatan);
//Animal[] animals= new Animal[] {dog, cat, yonatan, lion};
//for (int i = 0; i < animals.Length; i++)
//{
//    Console.WriteLine(animals[i].sayhello());
//}
//foreach (Animal animal in animals)
//{
//    Console.WriteLine(animal.sayhello());
//}
//static void sayhello(Animal animal)
//{
//    Console.WriteLine(animal.sayhello());
//}
Student roy= new Student() { Age= 17, Name="Roy"};
Student ido = new Student() { Age = 3, Name = "Ido" };
Student benia = new Student() { Age = 67, Name = "Benia" };
Student lior = new Student() { Age = 18, Name = "Lior" };
Student alma = new Student() { Age = 1, Name = "Alma" };
Student dana = new Student() { Age = 19, Name = "Dana" };
Student amit = new Student() { Age = 11, Name = "Amit" };
Student nevo = new Student() { Age = 42, Name = "Nevo" };
Student[] students = { roy, ido, benia, lior, alma , dana , amit , nevo};
Array.Sort(students);
foreach (Student student in students)
{
    Console.WriteLine(student);
}
Console.WriteLine("hello to github");