using _4Aprel_tapsiriq;

internal class Program
{
    private static void Main(string[] args)
    {
       Student student = new Student();
        student.Name = "en";
        Console.WriteLine( student.name);
        Universty uni=new Universty("salam",12);
        int std = 1;

                Console.WriteLine("Universtetin adi");
                Console.ReadLine();
                Console.WriteLine("Id ni daxil edin");
                Int32.TryParse(Console.ReadLine(), out uni.Id);
                
        for (int i = 0; i < std; i++)
        {
            std++;


            
                string click = Console.ReadLine();
             

            if (click == "1")
                {
                    
                    Console.WriteLine("Created Student"); ;
                    Console.Write("Telebenin adi -" + " ");
                    student.Name = Console.ReadLine();
                    Console.Write("Telebenin soyadi -" + " ");
                    student.Surname = Console.ReadLine();
                    
                   

                }



                if (click == "2")
                {

                    Console.WriteLine("Get Studnet");
                    Console.WriteLine(student.Name + " " + student.Surname);
                }



                if (click == "3")
                {
                    Console.WriteLine("Exit");
                    break;
                }

            




        }
    }
}