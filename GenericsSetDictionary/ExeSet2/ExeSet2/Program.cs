namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> courseA = new List<int>();
            List<int> courseB = new List<int>();
            List<int> courseC = new List<int>();

            Console.Write("How mary students for course A: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int student = int.Parse(Console.ReadLine());
                courseA.Add(student);
            }

            Console.Write("How mary students for course B: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int student = int.Parse(Console.ReadLine());
                courseB.Add(student);
            }

            Console.Write("How mary students for course C: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int student = int.Parse(Console.ReadLine());
                courseC.Add(student);
            }

            HashSet<int> all = new HashSet<int>(courseA);
            all.UnionWith(courseB);
            all.UnionWith(courseC);
            Console.WriteLine("Total students: " + all.Count);


        }
    }
}