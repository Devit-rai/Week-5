class Program
{
    static void Main(string[] args)
    {
        //Task 1
        // Create bank account object
        BankAccount acc = new BankAccount("ACC1001", 500);

        Console.WriteLine($"Account Number: {acc.AccountNumber}");
        Console.WriteLine($"Initial Balance: {acc.Balance}");

        // Deposit money
        acc.Deposit(300);
        Console.WriteLine($"Balance after deposit: {acc.Balance}");

        // Withdraw money
        acc.Withdraw(200);
        Console.WriteLine($"Balance after withdrawal: {acc.Balance}");

        //-------------------
        //Task 2
        
        // Creating Car object
        Car car = new Car()
        {
            Brand = "Toyota",
            Speed = 180,
            Seats = 5
        };

        // Creating Motorcycle object
        Motorcycle moto = new Motorcycle()
        {
            Brand = "Yamaha",
            Speed = 150,
            Type = "Sports"
        };

        // Calling base class methods (reusability)
        car.Start();
        car.DisplayInfo();
        car.Stop();

        Console.WriteLine();

        moto.Start();
        moto.DisplayInfo();
        moto.Stop();

        //Task 3
        Printer p = new Printer();

        p.Print("Hello World");     
        p.Print(123);                
        p.Print("Repeat Me", 3); 

        //Task 3

        NepaliTeacher nt = new NepaliTeacher();
        nt.Name = "Mr. Ram";
        Console.WriteLine(nt.Name);
        nt.Teaching();
        nt.SalaryInfo();

        Console.WriteLine();

        EnglishTeacher et = new EnglishTeacher();
        et.Name = "Ms. Sita";
        Console.WriteLine(et.Name);
        et.Teaching();
        et.SalaryInfo();


        Car2 carr = new Car2();
        Bike2 bike = new Bike2();

        Console.WriteLine("Car:");
        carr.Display();
        carr.StartEngine();
        carr.StopEngine();

        Console.WriteLine();

        Console.WriteLine("Bike:");
        bike.Display();
        bike.StartEngine();
        bike.StopEngine();

        // Task 5 OOP Derived Classes

        Laptop lap = new Laptop("Dell", 85000);
        Smartphone phone = new Smartphone("Samsung", 50000);

        Console.WriteLine("Laptop:");
        lap.ShowInfo();
        lap.TurnOnBattery();

        Console.WriteLine();

        Console.WriteLine("Smartphone:");
        phone.ShowInfo();
        phone.EnableCamera();

        //Task 5 OOP
        ElectronicsStore store = new ElectronicsStore();

        Laptop laptop = new Laptop("Dell", 85000);
        Smartphone phones = new Smartphone("Samsung", 50000);

        // Add devices
        store.AddDevice(laptop);
        store.AddDevice(phones);

        Console.WriteLine();

        // Display all devices and call child-specific methods
        store.ShowAllDeviceDetails();

        // Remove a device
        store.RemoveDevice(lap);

        Console.WriteLine();
        store.ShowAllDeviceDetails();

    
        // 2. Create Laptop and Smartphone objects
        Laptop laptop1 = new Laptop("Dell", 85000);
        Smartphone phone1 = new Smartphone("Samsung", 50000);

        // 3. Add devices to the store
        store.AddDevice(laptop1);
        store.AddDevice(phone1);

        Console.WriteLine();

        // 4. Display all device details including child-specific behavior
        store.ShowAllDeviceDetails();
    }
}
