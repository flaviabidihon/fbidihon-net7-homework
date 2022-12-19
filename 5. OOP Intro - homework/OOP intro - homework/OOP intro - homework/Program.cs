using OOP_intro___homework;

//exercise 1
Book book = new Book("War and Peace", "Leo Tolstoy", 1869);

Console.WriteLine(book.GetTitle()); // Outputs "War and Peace"
Console.WriteLine(book.GetAuthor()); // Outputs "Leo Tolstoy"
Console.WriteLine(book.GetYear()); // Outputs 1869

book.SetTitle("Anna Karenina");
book.SetAuthor("Leo Tolstoy");
book.SetYear(1877);

Console.WriteLine(book.GetTitle()); // Outputs "Anna Karenina"
Console.WriteLine(book.GetAuthor()); // Outputs "Leo Tolstoy"
Console.WriteLine(book.GetYear()); // Outputs 1877



//exercise 2
Console.WriteLine();
Product product = new Product("Apple", 0.99, 10);

Console.WriteLine(product.GetName()); // Outputs "Apple"
Console.WriteLine(product.GetPrice()); // Outputs 0.99
Console.WriteLine(product.GetQuantity()); // Outputs 10

product.SetName("Orange");
product.SetPrice(1.49);
product.SetQuantity(20);

Console.WriteLine(product.GetName()); // Outputs "Orange"
Console.WriteLine(product.GetPrice()); // Outputs 1.49
Console.WriteLine(product.GetQuantity()); // Outputs 20



// exercise 3
Console.WriteLine();
Animal animal = new Animal("Max", "Dog", "Labrador Retriever", 2, "Yellow", 75, true);

Console.WriteLine(animal.GetName()); // Outputs "Max"
Console.WriteLine(animal.GetSpecies()); // Outputs "Dog"
Console.WriteLine(animal.GetBreed()); // Outputs "Labrador Retriever"
Console.WriteLine(animal.GetAge()); // Outputs 2
Console.WriteLine(animal.GetColor()); // Outputs "Yellow"
Console.WriteLine(animal.GetWeight()); // Outputs 75
Console.WriteLine(animal.IsSpayedOrNeutered()); // Outputs true

animal.SetName("Buddy");
animal.SetSpecies("Cat");
animal.SetBreed("Siamese");
animal.SetAge(5);
animal.SetColor("Gray");
animal.SetWeight(12);
animal.SetIsSpayedOrNeutered(false);

Console.WriteLine(animal.GetName()); // Outputs "Buddy"
Console.WriteLine(animal.GetSpecies()); // Outputs "Cat"
Console.WriteLine(animal.GetBreed()); // Outputs "Siamese"
Console.WriteLine(animal.GetAge()); // Outputs 5
Console.WriteLine(animal.GetColor()); // Outputs "Gray"
Console.WriteLine(animal.GetWeight()); // Outputs 12
Console.WriteLine(animal.IsSpayedOrNeutered()); // Outputs false



// exercise 4
Console.WriteLine();
Calculator calculator = new Calculator();

Console.WriteLine(calculator.Add(2, 3)); // Outputs 5
Console.WriteLine(calculator.Subtract(5, 2)); // Outputs 3
Console.WriteLine(calculator.Multiply(3, 4)); // Outputs 12
Console.WriteLine(calculator.Divide(10, 5)); // Outputs 2
Console.WriteLine(calculator.Power(2, 3)); // Outputs 8
Console.WriteLine(calculator.SquareRoot(9)); // Outputs 3



// exercise 5
Console.WriteLine();
University myUniversity = new University("My University");
myUniversity.students = new List<Student>();
myUniversity.faculties = new List<Faculty>();

Student john = new Student("John", "Doe", 123456, 3.8);
Student jane = new Student("Jane", "Smith", 654321, 3.6);

myUniversity.AddStudent(john);
myUniversity.AddStudent(jane);

Faculty mary = new Faculty("Mary", "Jones", 111111, new List<string> { "Math", "Physics" });
Faculty bob = new Faculty("Bob", "Smith", 222222, new List<string> { "English", "History" });

myUniversity.AddFaculty(mary);
myUniversity.AddFaculty(bob);

Console.WriteLine(myUniversity.GetStudentCount()); // Outputs 2
Console.WriteLine(myUniversity.GetFacultyCount()); // Outputs 2



// exercise 6 + 7
Console.WriteLine();
CollegeEx6 college = new CollegeEx6();
college.name = "Al. I. Cuza";

StudentEx6 flavia = new StudentEx6("Flavia", DateTime.Now.AddYears(-10), DateTime.Now.AddYears(-5), college, DateTime.Now.AddYears(-30));
flavia.Print();
Console.WriteLine(flavia.IsStillStudent());

ProfessorEx6 profa = new ProfessorEx6("Popeasca", college, "medicina");
profa.studentsWhoGiveTheirDegree = new List<string> { "Danut", "Dana" };
profa.AddStudent("Daniela");
profa.RemoveStudent("Dana");
profa.PrintStudents();

