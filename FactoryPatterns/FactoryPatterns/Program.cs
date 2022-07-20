

//     DONE    Create an Interface named IVehicle that has a stubbed out public
//void Drive method.
//Create 2 new public classes that will conform to IVehicle.
//Example) Car, Motorcycle, BigRig
//Note: These classes must conform to IVehicle and implement
//the Drive() method - which will just
//Console.WriteLine(“Building a new Car!”)

//Now we will make our static VehicleFactory class.
//It will contain a static method GetVehicle(), that will return
//an IVehicle based on the amount of tires it’s given as a parameter
//Call this functionality in the Main method.

using FactoryPatterns;

Console.WriteLine("How many wheels does the vehicle you want to create have?");
Console.Write("Answer 1, 2, 3 or 4: ");
int userInput = Convert.ToInt32(Console.ReadLine());

IVehicle vehicle = VehicleFactory.GetVehicle(userInput);
vehicle.MakeVehicle();


