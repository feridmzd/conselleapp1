using ConsoleApp1.Models;


namespace ConsoleApp1
{
    public class Program
    {

        static void Main(string[] args)
        {
            Classroom classroom = null;
            Console.ForegroundColor = ConsoleColor.Red;
            
            Console.WriteLine(@"
           _____ _                                         
          / ____| |                                        
         | |    | | __ _ ___ ___ _ __ ___   ___  _ __ ___  
         | |    | |/ _` / __/ __| '__/ _ \ / _ \| '_ ` _ \ 
         | |____| | (_| \__ \__ | | | (_) | (_) | | | | | |
          \_____|_|\__,_|___|___|_|  \___/ \___/|_| |_| |_|
                                                   
                                                   
"); Console.ForegroundColor = ConsoleColor.Red;


            while (true)
                
            {
              


                Console.ForegroundColor=ConsoleColor.White;
                Console.WriteLine("1. Sinif yarat");
                Console.WriteLine("2. Telebe yarat");
                Console.WriteLine("3. Butun Telebeleri ekrana cixart");
                Console.WriteLine("4. Secilmis sinifdeki telebeleri ekrana cixart");
                Console.WriteLine("5. Telebe sil");
                Console.WriteLine("6. Cixis");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    
                    case 1:
                        Console.WriteLine("Sinif adini daxil edin:");
                        string className = Console.ReadLine();
                        Console.WriteLine("Sinif tipini daxil edin (Backend/Frontend):");
                        string classTypeStr = Console.ReadLine();
                        Classnum classType = (Classnum)Enum.Parse(typeof(Classnum), classTypeStr);
                        classroom = new Classroom(1, className, classType);
                        break;
                    case 2:
                        if (classroom == null)
                        {
                            Console.WriteLine("Xahiş edirik evvelce sinif yaradın.");
                            break;
                        }
                        Console.WriteLine("Telebe adini daxil edin:");
                        string studentName = Console.ReadLine();
                        Console.WriteLine("Telebe soyadini daxil edin:");
                        string studentSurname = Console.ReadLine();
                        Student student = new Student( studentName, studentSurname);
                        classroom.Addstudent(student);
                        break;
                    case 3:
                        if (classroom == null)
                        {
                            Console.WriteLine("Sinif yoxdur.");
                            break;
                        }
                        classroom.Allstudents();
                        break;
                    case 4:
                        Console.WriteLine("ID daxil et");
                        int id = Convert.ToInt32(Console.ReadLine());
                        classroom.FindStudentById(id);


                        break;
                    case 5:
                        if (classroom == null)
                        {
                            Console.WriteLine("Sinif yoxdur.");
                            break;
                        }
                        Console.WriteLine("Silmek istediyiniz telebenin ID-sini daxil edin:");
                        int studentId = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            classroom.Deletestudentbyid(studentId);
                            Console.WriteLine("Telebe uğurla silindi.");
                        }
                        catch (StudentNotFoundException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                   
                    case 6:

                        Console.WriteLine("Cixis edildi...");
                        
                        break;

                    default:
                        Console.WriteLine("Yanlis secim.");
                        break;
                }
            }
        }
    }
}



