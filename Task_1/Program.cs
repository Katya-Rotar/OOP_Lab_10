using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        Type myType = typeof(HarvestingFields);
        FieldInfo[] fields = myType.GetFields();
        while (true)
        {
            string input = Console.ReadLine();
            foreach (FieldInfo field in fields)
            {
                if (input == "private")
                {
                    Console.WriteLine($"private {field.FieldType.Name} {field.Name}");
                }
                else if (input == "protected")
                {
                    Console.WriteLine($"protected {field.FieldType.Name} {field.Name}");
                }
                else if (input == "public")
                {
                    Console.WriteLine($"public {field.FieldType.Name} {field.Name}");
                }
                else if (input == "all")
                {
                    Console.WriteLine($"public {field.FieldType.Name} {field.Name}");
                    Console.WriteLine($"protected {field.FieldType.Name} {field.Name}");
                    Console.WriteLine($"private {field.FieldType.Name} {field.Name}");
                }
            }
        }
    }
}