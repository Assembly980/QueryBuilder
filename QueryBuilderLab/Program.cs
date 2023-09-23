namespace QueryBuilderLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Starting off getting the folder that all of the material is in
            //Used later
            string folder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
            string file = folder + Path.DirectorySeparatorChar;

            //User Driver
            //Prompt user for a specific database first
            string UserInput = "l";
            string UserInput2 = "k";
            QueryBuilder build;

            while (UserInput != "3")
            {
                DatabaseMenu();
                UserInput = Console.ReadLine();


                switch (UserInput)
                {
                    case "1":
                        //Pokemon file
                        file += "Data" + Path.DirectorySeparatorChar + "data.db";
                        build = new QueryBuilder(file);
                        Console.WriteLine("Database Successfully Chosen\n");

                        while (UserInput2 != "q")
                        {
                            MainMenu();
                            UserInput2 = Console.ReadLine().ToLower();

                            switch (UserInput2)
                            {
                                case "c":
                                    //Create Once
                                    Console.Write("Please enter an Id: ");
                                    int userId = Convert.ToInt32(0 + Console.ReadLine());
                                    int userDexNum = userId;
                                    Console.Write("Please enter a Name: ");
                                    string userName = Console.ReadLine();
                                    Console.Write("Please enter a Form (Or press enter to skip): ");
                                    string userForm = Console.ReadLine();
                                    Console.Write("Please enter the First Type: ");
                                    string userType1 = Console.ReadLine();
                                    Console.Write("Please enter the Second Type (Or press enter to skip): ");
                                    string userType2 = Console.ReadLine();
                                    int userTotalStats;
                                    Console.Write("Please enter a value for HP: ");
                                    int userHP = Convert.ToInt32(0 + Console.ReadLine());
                                    Console.Write("Please enter a value for Attack: ");
                                    int userAttack = Convert.ToInt32(0 + Console.ReadLine());
                                    Console.Write("Please enter a value for Defense: ");
                                    int userDefense = Convert.ToInt32(0 + Console.ReadLine());
                                    Console.Write("Please enter a value for Special Attack: ");
                                    int userSpecialAttack = Convert.ToInt32(0 + Console.ReadLine());
                                    Console.Write("Please enter a value for Special Defence: ");
                                    int userSpecialDefense = Convert.ToInt32(0 + Console.ReadLine());
                                    Console.Write("Please enter a value for Speed: ");
                                    int userSpeed = Convert.ToInt32(0 + Console.ReadLine());
                                    Console.Write("What generation is your Pokemon? ");
                                    int userGen = Convert.ToInt32(0 + Console.ReadLine());
                                    userTotalStats = userHP + userAttack + userDefense + userSpecialAttack + userSpecialDefense + userSpeed;
                                    Pokemon u = new Pokemon()
                                    {
                                        Id = userId,
                                        DexNumber = userDexNum,
                                        Name = userName,
                                        Form = userForm, 
                                        Type1 = userType1,
                                        Type2 = userType2,
                                        Total = userTotalStats,
                                        HP = userHP,
                                        Attack = userAttack,
                                        Defense = userDefense,
                                        SpecialAttack = userSpecialAttack,
                                        SpecialDefense = userSpecialDefense,
                                        Speed = userSpeed,
                                        Generation = userGen
                                    };

                                    build.Create(u);
                                    Console.WriteLine($"Pokemon \"{userName}\" was added to the Pokedex!\n");
                                    break;

                                case "p":
                                    //Create All
                                    var list = ReadPokemonCSV(folder);
                                    int i = 0;
                                    foreach(var item in list)
                                    {
                                        build.Create(item);
                                        i++;
                                    }
                                    Console.WriteLine($"All {i} Items Successfully Added");
                                    //Do something with a foreach loop and the create method

                                    break;

                                case "r":
                                    //Read Once
                                    Console.WriteLine("I'm sorry, This has not been fully implemented yet.\nPlease check again later.");
                                    break;

                                case "v":
                                    //Read All
                                    Console.WriteLine("I'm sorry, This has not been fully implemented yet.\nPlease check again later.");
                                    break;

                                case "u":
                                    //Update Once
                                    Console.WriteLine("I'm sorry, This has not been fully implemented yet.\nPlease check again later.");
                                    break;

                                case "d":
                                    //Delete Once
                                    Console.WriteLine("I'm sorry, This has not been fully implemented yet.\nPlease check again later.");
                                    break;

                                case "e":
                                    //Empty the Entire Database Table
                                    build.DeleteAll<Pokemon>();
                                    Console.WriteLine("Database Emptied. ");
                                    break;

                                case "q":
                                    //Quit
                                    break;

                                default:
                                    Console.WriteLine($"\"{UserInput2}\" is not valid");
                                    Console.WriteLine("Please try again\n");
                                    break;
                            }
                        }
                        UserInput = "3";
                        break;

                    case "2":
                        //Banned Games file
                        file += "Data" + Path.DirectorySeparatorChar + "data.db";
                        build = new QueryBuilder(file);
                        Console.WriteLine("Database Successfully Chosen\n");

                        while (UserInput2 != "q")
                        {
                            MainMenu();
                            UserInput2 = Console.ReadLine().ToLower();

                            switch (UserInput2)
                            {
                                case "c":
                                    //Create Once
                                    Console.Write("Please enter an Id: ");
                                    int userId = Convert.ToInt32(0 + Console.ReadLine());
                                    Console.Write("Please enter the game's Title: ");
                                    string userTitle = Console.ReadLine();
                                    Console.Write("Please enter the game's Series: ");
                                    string userSeries = Console.ReadLine();
                                    Console.Write("Please enter the Country: ");
                                    string userCountry = Console.ReadLine();
                                    Console.Write("Please enter the Details: ");
                                    string userDetails = Console.ReadLine();
                                    BannedGame u = new BannedGame()
                                    {
                                        Id = userId,
                                        Title = userTitle,
                                        Series = userSeries,
                                        Country = userCountry,
                                        Details = userDetails
                                    };

                                    build.Create(u);
                                    Console.WriteLine($"Game \"{userTitle}\" has been successfully added! \n");
                                    break;

                                case "p":
                                    //Create All
                                    var list = ReadBannedGamesCSV(folder);
                                    int i = 0;
                                    foreach(var item in list)
                                    {
                                        build.Create(item);
                                        i++;
                                    }
                                    Console.WriteLine($"All {i} Items successfully Added!");
                                    i = 0; 
                                    //Do something with a foreach loop and the create method

                                    break;

                                case "r":
                                    //Read Once
                                    Console.WriteLine("I'm sorry, This has not been fully implemented yet.\nPlease check again later.");
                                    break;

                                case "v":
                                    //Read All
                                    Console.WriteLine("I'm sorry, This has not been fully implemented yet.\nPlease check again later.");
                                    break;

                                case "u":
                                    //Update Once
                                    Console.WriteLine("I'm sorry, This has not been fully implemented yet.\nPlease check again later.");
                                    break;

                                case "d":
                                    //Delete Once
                                    Console.WriteLine("I'm sorry, This has not been fully implemented yet.\nPlease check again later.");
                                    break;

                                case "e":
                                    //Empty the Entire Database Table
                                    build.DeleteAll<BannedGame>();
                                    Console.WriteLine("Database emptied. ");
                                    break;

                                case "q":
                                    //Quit
                                    break;

                                default:
                                    Console.WriteLine($"\"{UserInput2}\" is not valid");
                                    Console.WriteLine("Please try again\n");
                                    break;
                            }
                        }
                        UserInput = "3";
                        break;

                    case "3":
                        //Quit
                        break;

                    default:
                        Console.WriteLine($"\"{UserInput}\" is not a valid entry");
                        Console.WriteLine("Please try again\n");
                        break;
                }
            }
        }

        static void MainMenu()
        {
            //Started with CRUD, added as necessary
            //NOT FULLY COMPLETE!! WIP
            Console.WriteLine("Please Select an option\n");
            Console.WriteLine("c - Create a single object");
            Console.WriteLine("p - Populate the entire database");
            Console.WriteLine("r - Read a line from the database");
            Console.WriteLine("v - View the entire database");
            Console.WriteLine("u - Update a row from the database");
            Console.WriteLine("d - Delete a row from the database");
            Console.WriteLine("e - Empty the entire database");
            Console.WriteLine("q - Quit the program");
        }

        static void DatabaseMenu()
        {
            Console.WriteLine("Please Select a Database\n");
            Console.WriteLine("1 - Pokedex");
            Console.WriteLine("2 - Banned Games");
            Console.WriteLine("3 - Exit the Program");
        }

        static List<Pokemon> ReadPokemonCSV(string file)
        {
            List<Pokemon> fullList = new List<Pokemon>();

            using (var sr = new StreamReader(file + Path.DirectorySeparatorChar + "AllPokemon.csv"))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    var data = line.Split(',');

                    var p = new Pokemon()
                    {
                        Id = Convert.ToInt32(data[0]),
                        DexNumber = Convert.ToInt32(data[0]),
                        Name = data[1],
                        Form = data[2],
                        Type1 = data[3],
                        Type2 = data[4],
                        Total = Convert.ToInt32(data[5]),
                        HP = Convert.ToInt32(data[6]),
                        Attack = Convert.ToInt32(data[7]),
                        Defense = Convert.ToInt32(data[8]),
                        SpecialAttack = Convert.ToInt32(data[9]),
                        SpecialDefense = Convert.ToInt32(data[10]),
                        Speed = Convert.ToInt32(data[11]),
                        Generation = Convert.ToInt32(data[12])
                    };

                    fullList.Add(p);
                }
            }
            return fullList;
        }

        static List<BannedGame> ReadBannedGamesCSV(string File)
        {
            List<BannedGame> bannedGames = new List<BannedGame>();
            int i = 0;
            using (var sr = new StreamReader(File + Path.DirectorySeparatorChar + "BannedGames.csv"))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    var data = line.Split(',');

                    var bg = new BannedGame()
                    {
                        Id = i,
                        Title = data[0],
                        Series = data[1],
                        Country = data[2],
                        Details = data[3]
                    };

                    bannedGames.Add(bg);
                    i++;
                }
            }

            return bannedGames;
        }
    }
}