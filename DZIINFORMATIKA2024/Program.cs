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
                    try
                    {
                        List<string> command = line
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                        if (command[0] == "enrollment")
                        {
                            var firstName = command[1];
                            var lastName = command[2];
                            var id = command[3];
                            int age = int.Parse(command[4]);
                            var parentLastName = command[5];
                            var parentGsm = command[6];
                            Kid kid = new Kid(firstName, lastName, id, age, parentLastName, parentGsm);
                            Console.WriteLine(kinderGarden.EnrollKid(kid));
                        }
                        else if (command[0] == "unsubscribe")
                        {
                            string id = command[1];
                            Console.WriteLine(kinderGarden.ReleaseKid(id));
                        }
                        else if (command[0] == "information")
                        {
                            string group = command[1];
                            Console.WriteLine(kinderGarden.GroupInfo(group));
                        }
                        else if (command[0] == "END")
                        {
                            Console.WriteLine("Have a nice day!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"{command[0]} - invalid command.");
                        }
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
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
