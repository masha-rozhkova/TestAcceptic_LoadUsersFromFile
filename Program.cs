using System;

namespace LoadUsersFromFile
{
    class Program
    {
        const string UsersJsonPath = @"data.json";
        const string UsersXmlPath = @"data.xml";
        static void Main(string[] args)
        {
            try
            {
                var users = IOUtil.ParseJsonFile<AppData>(UsersJsonPath);
                IOUtil.WriteToXmlFile(users, UsersXmlPath);
                Console.WriteLine($"File {UsersXmlPath} was written");
                Console.ReadLine();
            } catch(Exception ex)
            {
                Console.WriteLine($"App error:\n{ex.Message}");
                Console.ReadLine();
            }           
        }
    }
}
