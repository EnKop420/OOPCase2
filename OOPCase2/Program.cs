using OOPCase2.Codes;

ServiceList list = new();
Vehicle car = new Vehicle();
list.Service = new();
Mechanic martin = new("Martin", "Jensen", 11111111, EnumMechanicType.bilMekaniker);
Mechanic thomas = new("Thomas", "Hansen", 22222222, EnumMechanicType.motorcykelMekaniker);
Mechanic henrik = new("Henrik", "Nielsen", 33333333, EnumMechanicType.lastbilMekaniker);

Mechanic mechanic = new();

string firstname = Console.ReadLine();
string lastname = Console.ReadLine();
int tlfnr = Convert.ToInt32(Console.ReadLine());
string vehicleTypeSearch = Console.ReadLine();
EnumVehicleType? vehicleType = car.getVehicleType(vehicleTypeSearch.ToLower());
string nummerplade = Console.ReadLine();
string vehicleBrand = Console.ReadLine();
string vehicleModel = Console.ReadLine();
DateOnly vehicleYear = DateOnly.Parse(Console.ReadLine());


list.AddCustomer(new ServiceList(new Customer(firstname, lastname, tlfnr, new Vehicle(vehicleType, nummerplade, vehicleBrand, vehicleModel, vehicleYear)), mechanic));
Console.Clear();
foreach (var item in list.Service)
{
    Console.WriteLine($"{item.Customers.FirstName} {item.Customers.LastName} {item.Customers.TlfNummer}\n{item.Mechanics.FirstName} {item.Mechanics.LastName} {item.Mechanics.TlfNummer}");
    Console.WriteLine($"{item.Customers.Car.VehicleType} {item.Customers.Car.VehiclePlate} {item.Customers.Car.VehicleBrand} {item.Customers.Car.VehicleModel} {item.Customers.Car.VehicleYear}");
}