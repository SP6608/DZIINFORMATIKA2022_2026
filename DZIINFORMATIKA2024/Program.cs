namespace DZIINFORMATIKA2024
{
    using System.IO;
    public class Program
    {
        static void Main(string[] args)
        {
			try
			{
                KinderGarden kinderGarden=new KinderGarden();
                StreamReader r = new StreamReader("data.txt");
                string readFile=r.ReadToEnd();
                List<string> lines = readFile.Split(Environment.NewLine).ToList();
                //Обхождаме всички редове на файла
                foreach (string line in lines) 
                { 
                   List<string>command=line
                        .Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();
                    if (command[0]== "enrollment")
                    {
                        var firstName = command[1];
                        var lastName = command[2];
                        var id= command[3];
                        int age=int.Parse(command[4]);
                        var parentLastName=command[5];
                        var parentGsm=command[6];
                        Kid kid = new Kid(firstName, lastName, id, age, parentLastName, parentGsm);
                        Console.WriteLine(kinderGarden.EnrollKid(kid));
                    }

                }
			}
			catch (Exception ex)
			{

                Console.WriteLine(ex.Message);
			}
        }
    }
}
