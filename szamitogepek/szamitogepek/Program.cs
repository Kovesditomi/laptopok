namespace szamitogepek
{
    internal class Program
    {
        static List<Szamitogep> Szamitogeps(List<Szamitogep> a);
        

        static void Main(string[] args)
        {
            var szamitogepek=new List<Szamitogep>();
            using var sr = new StreamReader(@"..\..\..\src\szamitogepek.txt");
            { 
            
            sr.ReadLine();
                while (sr.EndOfStream)
                {
                    szamitogepek.Add(new Szamitogep(sr.ReadLine()));
                }
           
            }
            foreach (var item in szamitogepek)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("7. feladat");
            foreach (var item in Szamitogeps(szamitogepek));
            {
                if (item = null)
                {

                }
            
            }
        }
    }
}