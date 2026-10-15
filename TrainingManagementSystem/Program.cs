using TrainingManagementSystem.Models;
using TrainingManagementSystem.Services;

Course[] courses =
{
    new Course("101A", "Java", 5000m, 30, 20, 16),
    new Course("101B", "Python", 6000m, 30, 20, 15),
    new Course("102A", "JS", 4000m, 20, 20, 12),
    new Course("102B", "HTML,CSS", 3000m, 10, 20, 10),
    new Course("103A", "Dotnet", 6000m, 50, 20, 17)
};

CourseService courseService = new CourseService(courses);
LearnerService learnerService = new LearnerService();

bool running = true;

while (running)
{
    Console.WriteLine("\n----- TRAINING MANAGEMENT SYSTEM ----");
    Console.WriteLine("1. Display Courses");
    Console.WriteLine("2. Search Course");
    Console.WriteLine("3. Sort Courses by Fee");
    Console.WriteLine("4. Display Available Seats");
    Console.WriteLine("5. Register Learner");
    Console.WriteLine("6. Display Learners");
    Console.WriteLine("7. Search Learner");
    Console.WriteLine("0. Exit");
    Console.Write("Enter your choice: ");

    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            courseService.Display();
            break;

        case "2":
            Console.Write("Enter Course Title: ");
            string title = Console.ReadLine() ?? "";
            courseService.Search(title);
            break;

        case "3":
            courseService.Sort();
            break;

        case "4":
            courseService.AvailableSeats();
            break;

        case "5":
            learnerService.Register();
            break;

        case "6":
            learnerService.Display();
            break;

        case "7":
            learnerService.Search();
            break;

        case "0":
            running = false;
            Console.WriteLine("Thank you for using the system!");
            break;

        default:
            Console.WriteLine("Invalid choice! Please try again.");
            break;
    }

    if (running)
    {
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }
}