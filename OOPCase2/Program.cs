using OOPCase2.Codes;
using System.Reflection.Metadata.Ecma335;
using System.Text;

ServiceList list = new();
VehicleInfo vehicle = new();
list.Service = new();
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
            Console.Clear();
            Console.WriteLine("Angiv kunden fornavn og efternavn");
            string[] fullName = Console.ReadLine().Split(" ");
            firstname = fullName[0];
            lastname = fullName.Last();
            int? tlfnr = null;
            CustomerInfo customer = new(firstname, lastname, tlfnr);
            List<string> CustomerList = customer.Search(list.Service);
            if (CustomerList.Count == 0)
            {
                throw new Exception("Kunden er ikke i systemet endnu");
            }
            foreach (var item in CustomerList)
            {
                Console.WriteLine(item);
            }
        }
        else if (userChoice == 2)
        {
            Console.Clear();
            Console.WriteLine("Angiv mekanikeren fornavn og efternavn");
            string[] fullName = Console.ReadLine().Split(" ");
            firstname = fullName[0];
            lastname = fullName.Last();
            int tlfnr = 0;
            EnumMechanicType mec1;
            mec1 = 0;
            MechanicInfo mechanicSearch = new(firstname, lastname, tlfnr, mec1);
            List<string> mechanicList = mechanicSearch.Search(list.Service);
            if (mechanicList.Count == 0)
            {
                throw new Exception("Der er ikke nogen mekaniker som arbejder på noget");
            }
            foreach (var item in mechanicSearch.Search(list.Service))
            {
                Console.WriteLine(item);
            }
        }
        else if (userChoice == 3)
        {
            Console.Clear();
            Console.WriteLine("Angiv kunden fornavn og efternavn");
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
            Console.WriteLine($"{EnumVehicleType.bil.ToString()}\n{EnumVehicleType.motorcykel.ToString()}\n{EnumVehicleType.lastbil.ToString()}");
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
            Console.WriteLine("Angiv bilens årgang (MM-DD-YYYY)");
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
            else if (closeApp == "y")
            {
                Console.WriteLine("Programmet lukker nu");
                System.Threading.Thread.Sleep(1000);
                break;
            }
        }
        //throw new Exception("Ugyldigt valg");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        Console.WriteLine("Tryk for at gå tilbage!");
        Console.ReadKey();
        Console.Clear();
    }
}