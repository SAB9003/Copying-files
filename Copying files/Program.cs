namespace Copying_files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  @"C:\Users\user\Desktop\С# hw\Copying files\Copying files\input.txt"
            //  @"..\..\..\input.txt"
            //  @"..\..\..\output.txt"
            Console.Write("Enter the path to the source file: ");
            string? input_file = Console.ReadLine();
            Console.Write("Enter the path to the file to which you want to copy the data: ");
            string? output_file = Console.ReadLine();
            try
            {
                if (!File.Exists(input_file))
                {
                    Console.WriteLine("Error: Source file not found.");
                    return;
                }
                string content = "\n" + File.ReadAllText(input_file);
                File.AppendAllText(output_file, content);

                Console.WriteLine("File copied successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
