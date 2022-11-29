using OOPCase2.Codes;

ServiceList list = new();
VehicleInfo vehicle = new();
list.Service = new();
MechanicInfo martin = new("Martin", "Jensen", 11111111, EnumMechanicType.bilMekaniker);
MechanicInfo thomas = new("Thomas", "Hansen", 22222222, EnumMechanicType.motorcykelMekaniker);
MechanicInfo henrik = new("Henrik", "Nielsen", 33333333, EnumMechanicType.lastbilMekaniker);
MechanicInfo mechanic = new();
string firstname;
string lastname;
while (true)
{
    try
    {
        Console.WriteLine("Velkommen til værkstedet\n1. For at søge efter en kunde\n2. for at søge efter en mekaniker\n3. For at oprette en ny kunde");
        int userChoice = Convert.ToInt32(Console.ReadLine());
        if (userChoice == 1)
        {

        }
        else if (userChoice == 2)
        {

        }
        if (userChoice == 3)
        {
            Console.Clear();
            Console.WriteLine("Angiv dit fornavn og efternavn");
            string[] fullName = Console.ReadLine().Split(" ");
            firstname = fullName[0];
            lastname = fullName.Last();

            Console.WriteLine("Angiv dit tlf nummer (skal være 8 cifre lang)");
            int tlfnr = Convert.ToInt32(Console.ReadLine());
            if (tlfnr.ToString().Length != 8)
            {
                throw new Exception("Telefon nummeret er ikke gyldigt! Prøv igen.");
            }
            Console.WriteLine("Angiv hvilken køretøjstype du vil tilføje");
            string vehicleTypeSearch = Console.ReadLine();
            EnumVehicleType? vehicleType = vehicle.getVehicleType(vehicleTypeSearch.ToLower());
            if (vehicleType == null)
            {
                throw new Exception($"Vi tager desværre ikke imod køretøjtypen {vehicleTypeSearch}");
            }
            Console.WriteLine("Angiv din nummerplade til bilen (skal se sådan her ud AA 12 345)");
            string vehiclePlate = Console.ReadLine().ToUpper();
            string[]? isValid = vehiclePlate.Split(" ");
            if (isValid[0].Length != 2 || isValid[1].Length != 2 || isValid[2].Length != 3 || isValid.Length == 2)
            {
                throw new Exception("Nummerpladen er ikke gyldig");
            }
            Console.WriteLine("Angiv bilens mærke");
            string vehicleBrand = Console.ReadLine();
            Console.WriteLine("Angiv bilens model");
            string vehicleModel = Console.ReadLine();
            Console.WriteLine("Angiv bilens årgang");
            string vehicleYearInString = Console.ReadLine();
            DateOnly vehicleYear;
            if (!DateOnly.TryParse(vehicleYearInString, out vehicleYear))
            {
                throw new Exception("Du har ikke angivet en gyldig dato");
            }
            vehicleYear = DateOnly.Parse(vehicleYearInString);

            VehicleInfo a = new VehicleInfo(vehicleType, vehiclePlate, vehicleBrand, vehicleModel, vehicleYear);
            CustomerInfo b = new CustomerInfo(firstname, lastname, tlfnr);
            ServiceList c = new ServiceList(b, a);
            list.Service.Add(c);

            Console.Clear();
            foreach (var item in list.Service)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine($"{item.Customers.FirstName} {item.Customers.LastName}\nTLF: {item.Customers.TlfNummer}\nMekaniker: {item.Vehicle.Mechanic.FirstName} {item.Vehicle.Mechanic.LastName}");
                Console.WriteLine($"Biltype: {item.Vehicle.VehicleType}\nNummerplade: {item.Vehicle.VehiclePlate}\nBilmærke {item.Vehicle.VehicleBrand}\nBilmodel {item.Vehicle.VehicleModel}\nBil årgang: {item.Vehicle.VehicleYear}");
                Console.WriteLine("---------------------");
            }
            Console.WriteLine("\nVil du afslutte applikationen? Y/N");
            string closeApp = Console.ReadLine().ToLower();
            if (closeApp == "n")
            {
                Console.WriteLine("Programmet starter forfra nu");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }
            else if(closeApp == "y")
            {
                Console.WriteLine("Programmet lukker nu");
                System.Threading.Thread.Sleep(1000);
                break;
            }
        }
        throw new Exception("Ugyldigt valg");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        Console.WriteLine("Tryk for at starte forfra!");
        Console.ReadKey();
        Console.Clear();
    }
}