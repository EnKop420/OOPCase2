using OOPCase2.Codes;

WorkerList list = new();

list.workerLists = new();

Worker martin = new("Martin", "Jensen", 11111111, EnumWorkType.bilMekaniker);
Worker thomas = new("Thomas", "Hansen", 22222222, EnumWorkType.motorcykelMekaniker);
Worker henrik = new("Henrik", "Nielsen", 33333333, EnumWorkType.lastbilMekaniker);

//string firstname = Console.ReadLine();
//string lastname = "Olesen";
//int tlfnr = 11111111;

//string nummerplade = "SD 420 69";
//string bilMærke = "Fiat";
//string bilModel = "Fiasko";
//DateOnly bilÅrgang = DateOnly.Parse("12/12/2000");


//list.AddCustomer(new WorkerList(new Customer(firstname, lastname, tlfnr, new Car(EnumCarType.bil, nummerplade, bilMærke, bilModel, bilÅrgang)), Worker.martin));

    Console.WriteLine(EnumCarType.bil.ToString());

