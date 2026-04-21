namespace HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            int lines = int.Parse(Console.ReadLine());
            


            List<string> coming = new List<string>();
            List<string> notComing = new List<string>();

            for ( int i = 0; i < lines; i++)
            {
                string command = Console.ReadLine();
                string name = command.Substring(0, command.IndexOf(' '));

                if (command.Contains("not"))
                {
                    //negative

                    if (coming.Contains(name))
                    {
                        coming.Remove(name);

                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list");
                    }

                    
                } else
                {
                    if (coming.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list");
                    }
                    else
                    {
                        coming.Add(name);
                    }
                }
            }
            foreach (string name in coming)
            {
                Console.WriteLine(name);
            }
            

        }
        

    }
}
