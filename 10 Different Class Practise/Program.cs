using _10_Different_Class_Practise;

TV tV = new TV(01,"Toshiba Led 42inch","OFF");
tV.SetPowerOn();
string powerOfTv = tV.Power;
Console.WriteLine("TV's power is "+ powerOfTv);

Car car = new Car();
car.CarID = 1;
car.Model = "Toyota axio 100";
car.SpeedKMph = 40;
int accelerateSpeed= car.Accelerate();
Console.WriteLine($"Ther car speed is now {accelerateSpeed} KMph");

AirCondition airCondition = new AirCondition { AirConditionID = 01, Model = "GREE 2 Ton", Temperature = 20 };
Console.WriteLine("Air Condition temperature is now "+ airCondition.setTemperature(26)+ " celcius");

Address address = new Address("Hateya", "Sakhipur", "Tangail");
string fullAddress = address.GetFullAdress();
Console.WriteLine("My Full address is "+fullAddress);

Customer customer = new Customer();
customer.CustomerID = 01;
customer.ShippingAddress = address.GetFullAdress();
Console.WriteLine("Customer Shipping Address is "+customer.getShippingAddress());

Book book = new Book() { Title = "Aj Chitrar Biye", Author = "Humayun Ahmed", PublishDate = DateTime.Parse("2003-01-03") };
string bookAuthor= book.GetAuthor();
Console.WriteLine(bookAuthor);

Employee employee = new Employee(101, "HR", 30000);
string employeeDepartment = employee.ChangeDepartmnet("IT");
Console.WriteLine(employeeDepartment);

School school = new School() { SchoolID=1005,Location="Dhaka", TotalStudent=500};
int currentTotalStudent = school.AdmitStudent(50);
Console.WriteLine("After addmission total Student is "+currentTotalStudent);

Animal animal = new Animal() { AnimalID=10, Name="Cow", Weight=500};
Console.WriteLine(animal.GetNameAndWeight());

Student student = new Student();
student.StudentID = 03;
student.Name = "Mahfoz";
student.StudyingClass = "Seven";
student.RollNumber = 01;
Console.WriteLine(student.Name+" is read in class "+student.getStudyingClass() );




