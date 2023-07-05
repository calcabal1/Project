using Microsoft.VisualBasic;

namespace FinalOutput
{
    internal class Program
    {
        static string[,] WalkIn_profile = new string[100, 8];
        static string[,] Membership_profile = new string[100, 8];
        static string[] level = new string[100];
        static string[] lev = new string[100];
        static int TotalMember = 0;
        static int TotalWalkIn = 0;
        static void Main(string[] args)

        {
            LogIn();
            bool loop = true;
            while (loop)
            {
                try
                {
                    switch (MainMenu())
                    {
                        case 1:
                            RegisterInformation();
                            break;
                        case 2:
                            FitnessRecord();
                            break;
                        case 3:
                            UpdateClient();
                            break;
                        case 4:
                            walkin();
                            break;
                        case 5:
                            Exit();
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.SetCursorPosition(60, 12);
                    Console.WriteLine("NO INFORMATION FOUND");
                    Console.SetCursorPosition(60, 14);
                    Console.Write("PRESS ENTER TO GO BACK...");
                    Console.ReadLine();


                }
            }
        }
        static void LogIn()
        {
            string rightPass = "1234";
            string right_user = "admin";
            int attempt = 3;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\n\n\n\n\n\n\n");
            Console.WriteLine("\t\t\t\t\t\t\t     ╔═══════════════════════════════════════════════╗");
            Console.WriteLine("\t\t\t\t\t\t\t     ║                                               ║");
            Console.WriteLine("\t\t\t\t\t\t\t     ║                    Log - In                   ║");
            Console.WriteLine("\t\t\t\t\t\t\t     ║                                               ║");
            Console.WriteLine("\t\t\t\t\t\t\t     ║    Enter Username:_____________________       ║");
            Console.WriteLine("\t\t\t\t\t\t\t     ║                                               ║");
            Console.WriteLine("\t\t\t\t\t\t\t     ║    Enter Passcode:_____________________       ║");
            Console.WriteLine("\t\t\t\t\t\t\t     ║                                               ║");
            Console.WriteLine("\t\t\t\t\t\t\t     ║                                               ║");
            Console.WriteLine("\t\t\t\t\t\t\t     ║                                               ║");
            Console.WriteLine("\t\t\t\t\t\t\t     ╚═══════════════════════════════════════════════╝");
            Console.SetCursorPosition(81, 12);
            string user = Console.ReadLine().ToLower();
            Console.SetCursorPosition(81, 14);
            string password = Console.ReadLine();
            while (attempt != 1)
            {
                if (password != rightPass || user != right_user)
                {
                    Console.Clear();
                    Console.SetCursorPosition(64, 10);
                    Console.WriteLine("WRONG USERNAME OR PASSWORD, ATTEMPT LEFT {0}", attempt - 1);
                    Console.WriteLine("\t\t\t\t\t\t\t     ╔═══════════════════════════════════════════════╗");
                    Console.WriteLine("\t\t\t\t\t\t\t     ║                                               ║");
                    Console.WriteLine("\t\t\t\t\t\t\t     ║                    Log - In                   ║");
                    Console.WriteLine("\t\t\t\t\t\t\t     ║                                               ║");
                    Console.WriteLine("\t\t\t\t\t\t\t     ║    Enter Username:_____________________       ║");
                    Console.WriteLine("\t\t\t\t\t\t\t     ║                                               ║");
                    Console.WriteLine("\t\t\t\t\t\t\t     ║    Enter Passcode:_____________________       ║");
                    Console.WriteLine("\t\t\t\t\t\t\t     ║                                               ║");
                    Console.WriteLine("\t\t\t\t\t\t\t     ║                                               ║");
                    Console.WriteLine("\t\t\t\t\t\t\t     ║                                               ║");
                    Console.WriteLine("\t\t\t\t\t\t\t     ╚═══════════════════════════════════════════════╝");
                    Console.SetCursorPosition(81, 15);
                    user = Console.ReadLine().ToLower();
                    Console.SetCursorPosition(81, 17);
                    password = Console.ReadLine();
                    attempt--;
                }
                else
                {
                    return;
                }
            }
            if (attempt == 1)
            {
                Console.SetCursorPosition(64, 19);
                Console.WriteLine("LOG IN LIMIT REACHED. PROGRAM TERMINATING.");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
        }
        static int MainMenu()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t\t\t\t\t\t\t     ╔═══════════════════════════════════════════════╗");
            Console.WriteLine("\t\t\t\t\t\t\t     ║                                               ║");
            Console.WriteLine("\t\t\t\t\t\t\t     ╚═══════════════════════════════════════════════╝");
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t\t\t\t\t\t      ╔═════════════════════════╗\t╔═════════════════════════╗");
            Console.WriteLine("\t\t\t\t\t\t      ║                         ║\t║                         ║");
            Console.WriteLine("\t\t\t\t\t\t      ║     REGISTER CLIENT     ║\t║ FITNESS PROGRAM RECORD  ║");
            Console.WriteLine("\t\t\t\t\t\t      ║           [1]           ║\t║           [2]           ║");
            Console.WriteLine("\t\t\t\t\t\t      ╚═════════════════════════╝\t╚═════════════════════════╝\n\n");
            Console.WriteLine("\t\t\t\t\t\t      ╔═════════════════════════╗\t╔═════════════════════════╗");
            Console.WriteLine("\t\t\t\t\t\t      ║                         ║\t║                         ║");
            Console.WriteLine("\t\t\t\t\t\t      ║VIEW UPDATE CLIENT RECORD║\t║   VIEW WALK IN RECORD   ║");
            Console.WriteLine("\t\t\t\t\t\t      ║           [3]           ║\t║           [4]           ║");
            Console.WriteLine("\t\t\t\t\t\t      ╚═════════════════════════╝\t╚═════════════════════════╝");
            Console.WriteLine("\t\t\t\t\t\t\t          ╔═══════════════════════════════════════╗");
            Console.WriteLine("\t\t\t\t\t\t\t          ║                 EXIT                  ║");
            Console.WriteLine("\t\t\t\t\t\t\t          ║                 [5]                   ║");
            Console.WriteLine("\t\t\t\t\t\t\t          ╚═══════════════════════════════════════╝");


            Console.WriteLine("\t\t\t\t\t\t\t     ╔═══════════════════════════════════════════════╗");
            Console.WriteLine("\t\t\t\t\t\t\t     ║                                               ║");
            Console.WriteLine("\t\t\t\t\t\t\t     ╚═══════════════════════════════════════════════╝");

            Console.SetCursorPosition(79, 5);
            Console.WriteLine(" MAIN MENU");
            Console.SetCursorPosition(79, 28);
            Console.Write("CHOICE: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        static void RegisterInformation()
        {
            if (TotalMember == Membership_profile.GetLength(1))
            {
                throw new Exception("Sorry the information or memory is currently full.");
            }
            string ans = "";
            do
            {
                Console.Clear();
                Console.SetCursorPosition(79, 5);
                Console.WriteLine("CHOOSE OPTION");
                Console.SetCursorPosition(62, 9);
                Console.WriteLine("===== MEMBERSHIP ===== || ===== WALK IN =====");
                Console.SetCursorPosition(62, 10);
                Console.WriteLine("======== [1] ========= || ======= [2] =======");
                Console.WriteLine("\t\t\t\t\t\t\t          ╔═════════════════════════════════════╗");
                Console.WriteLine("\t\t\t\t\t\t\t          ║                                     ║");
                Console.WriteLine("\t\t\t\t\t\t\t          ╚═════════════════════════════════════╝");

                Console.SetCursorPosition(68, 12);
                string answer = Console.ReadLine().ToUpper();

                if (answer == "MEMBERSHIP" || answer == "1")
                {
                    string discount = "";
                    Console.SetCursorPosition(60, 14);
                    Console.Write("ENTER FULL NAME: ");
                    string full_name = Console.ReadLine().ToUpper();
                    Console.SetCursorPosition(60, 15);
                    Console.Write("ENTER YOUR AGE: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.SetCursorPosition(60, 16);
                    Console.Write("ENTER YOUR GENDER[M/F]: ");
                    char gender = char.Parse(Console.ReadLine().ToUpper());
                    Console.SetCursorPosition(60, 17);
                    Console.Write("ENTER YOUR ADDRESS: ");
                    string address = Console.ReadLine().ToUpper();
                    Console.SetCursorPosition(60, 18);
                    Console.Write("ENTER YOUR CONTACT NUMBER: ");
                    string contactnum = Console.ReadLine();
                    Console.SetCursorPosition(60, 19);
                    Console.Write("CLIENT TYPE[STUDENT/ADULT]: ");
                    string type = Console.ReadLine().ToUpper();



                    if (type == "STUDENT")
                    {
                        discount = "25%";
                    }
                    else if (type == "ADULT")
                    {
                        discount = "10%";
                    }


                    Membership_profile[TotalMember, 0] = full_name;
                    Membership_profile[TotalMember, 1] = age.ToString();
                    Membership_profile[TotalMember, 2] = gender.ToString();
                    Membership_profile[TotalMember, 3] = address;
                    Membership_profile[TotalMember, 4] = contactnum;
                    Membership_profile[TotalMember, 5] = type;
                    Membership_profile[TotalMember, 6] = discount;
                    Membership_profile[TotalMember, 7] = "NONE";

                    TotalMember++;
                }
                else if (answer == "WALK IN" || answer == "WALKIN" || answer == "2")
                {
                    double payment = 100.00;
                    Console.SetCursorPosition(60, 14);
                    Console.Write("ENTER FULL NAME: ");
                    string full_name = Console.ReadLine().ToUpper();
                    Console.SetCursorPosition(60, 15);
                    Console.Write("ENTER YOUR AGE: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.SetCursorPosition(60, 16);
                    Console.Write("ENTER YOUR GENDER[M/F]: ");
                    char gender = char.Parse(Console.ReadLine().ToUpper());
                    Console.SetCursorPosition(60, 17);
                    Console.Write("ENTER YOUR ADDRESS: ");
                    string address = Console.ReadLine().ToUpper();
                    Console.SetCursorPosition(60, 18);
                    Console.Write("ENTER YOUR CONTACT NUMBER: ");
                    string contactnum = Console.ReadLine();
                    Console.SetCursorPosition(60, 19);
                    Console.Write("CLIENT TYPE[STUDENT/ADULT]: ");
                    String type = Console.ReadLine().ToUpper();
                    Console.SetCursorPosition(60, 20);
                    Console.Write("ENTER YOUR MONEY: ");
                    double money = double.Parse(Console.ReadLine());


                    while (money < 100)
                    {
                        Console.SetCursorPosition(60, 21);
                        Console.WriteLine("Please input a sufficient amount");
                        Console.SetCursorPosition(60, 22);
                        Console.Write("ENTER YOUR MONEY: ");
                        money = double.Parse(Console.ReadLine());
                    }

                    WalkIn_profile[TotalWalkIn, 0] = full_name;
                    WalkIn_profile[TotalWalkIn, 1] = age.ToString();
                    WalkIn_profile[TotalWalkIn, 2] = gender.ToString();
                    WalkIn_profile[TotalWalkIn, 3] = address;
                    WalkIn_profile[TotalWalkIn, 4] = contactnum;
                    WalkIn_profile[TotalWalkIn, 5] = type;
                    WalkIn_profile[TotalWalkIn, 6] = money.ToString();


                    TotalWalkIn++;
                }
                Console.SetCursorPosition(60, 23);
                Console.WriteLine("INFORMATION SUCCESFULLY SAVED.");
                Console.SetCursorPosition(60, 24);
                Console.Write("DO YOU WANT TO TRY AGAIN?: ");
                ans = Console.ReadLine().ToUpper();
                while (ans != "YES" && ans != "Y" && ans != "NO" && ans != "N")
                {
                    Console.SetCursorPosition(60, 27);
                    Console.WriteLine("INVALID ANSWER. PLEASE TRY AGAIN.");
                    Console.SetCursorPosition(60, 29);
                    Console.Write("DO YOU WANT TO TRY AGAIN?: ");
                    ans = Console.ReadLine().ToUpper();
                }
            } while (ans == "YES" || ans == "Y");

        }
        static void FitnessRecord()
        {
            string ans = "";
            do
            {
                Console.Clear();
                Console.SetCursorPosition(60, 5);
                Console.Write("FITNESS PROGRAM LEVEL");
                Console.SetCursorPosition(60, 7);
                Console.Write("ENTER FULL NAME: ");
                string fname = Console.ReadLine().ToUpper();
                bool found = false;
                for (int i = 0; i < TotalMember; i++)

                {
                    if (fname.ToUpper() == Membership_profile[i, 0].ToUpper()) 
                    {
                        if (Membership_profile[i, 7] == "NONE")
                        {
                            Console.SetCursorPosition(60, 9);
                            Console.WriteLine("CHOOSE FITNESS PROGRAM LEVEL");
                            Console.SetCursorPosition(60, 11);
                            Console.WriteLine("1. BEGINNER");
                            Console.SetCursorPosition(60, 13);
                            Console.WriteLine("2. INTERMIDIATE");
                            Console.SetCursorPosition(60, 15);
                            Console.WriteLine("3. ADVANCE");
                            Console.SetCursorPosition(60, 17);
                            Console.Write("CHOICE: ");
                            string choice = Console.ReadLine();



                            if (choice == "1")
                            {
                                Membership_profile[i, 7] = "BEGINNER";
                            }
                            else if (choice == "2")
                            {
                                Membership_profile[i, 7] = "INTERMIDIATE";
                            }
                            else if (choice == "3")
                            {
                                Membership_profile[i, 7] = "ADVANCE";
                            }

                        }
                        else
                        {
                            Console.WriteLine("This Member has already started a Fitness Program. You may update the level of the Fitness Program on the Update Option!");
                        }
                      
                        found = true;
                    }

                   
                    if (!found)
                    {
                        Console.SetCursorPosition(60, 20);
                        Console.WriteLine("Sorry no information found!!");
                    }
                    Console.SetCursorPosition(60, 21);
                    Console.Write("DO YOU WANT TO TRY AGAIN?: ");
                    ans = Console.ReadLine().ToUpper();
                    while (ans != "YES" && ans != "Y" && ans != "NO" && ans != "N")
                    {
                        Console.SetCursorPosition(60, 19);
                        Console.WriteLine("WRONG INPUT!! TRY AGAIN");
                        Console.SetCursorPosition(60, 21);
                        Console.Write("DO YOU WANT TO TRY AGAIN?: ");
                        ans = Console.ReadLine().ToUpper();
                    }
                } 

            } while (ans == "YES" || ans == "Y");
        }
        static void UpdateClient()
            {


                Console.Clear();
                Console.SetCursorPosition(60, 5);
                Console.Write("INPUT FULL NAME: ");
                string fname = Console.ReadLine().ToUpper();
                int idx = -1;
                for (int i = 0; i < Membership_profile.GetLength(1); i++)
                {
                    if (fname.ToUpper() == Membership_profile[i, 0].ToUpper())
                    {
                        idx = i;
                        break;
                    }
                }
                if (idx == -1)
                {
                    Console.WriteLine("Sorry no information found.");
                }

                else
                {
                    string ans = "";
                    do
                    {
                        Console.Clear();
                        Console.SetCursorPosition(78, 1);
                        Console.WriteLine("MEMBERSHIP");
                        Console.SetCursorPosition(75, 2);
                        Console.WriteLine("INFORMATION FOUND");
                        Console.SetCursorPosition(58, 3);
                        Console.WriteLine("\t---------------------------------------");
                        Console.SetCursorPosition(60, 5);
                        Console.WriteLine("\t\t     NAME      : {0}", Membership_profile[idx, 0]);
                        Console.SetCursorPosition(60, 7);
                        Console.WriteLine("\t\t     AGE       : {0}", Membership_profile[idx, 1]);
                        Console.SetCursorPosition(60, 9);
                        Console.WriteLine("\t\t     GENDER    : {0}", Membership_profile[idx, 2]);
                        Console.SetCursorPosition(60, 11);
                        Console.WriteLine("\t\t     ADDRESS   : {0}", Membership_profile[idx, 3]);
                        Console.SetCursorPosition(60, 13);
                        Console.WriteLine("\t\t     CONTACT # : {0}", Membership_profile[idx, 4]);
                        Console.SetCursorPosition(60, 15);
                        Console.WriteLine("\t\t     TYPE      : {0}", Membership_profile[idx, 5]);
                        Console.SetCursorPosition(60, 17);
                        Console.WriteLine("\t\t     DISCOUNT  : {0}", Membership_profile[idx, 6]);
                        Console.SetCursorPosition(60, 19);
                        Console.WriteLine("\t\t     LEVEL     : {0}", Membership_profile[idx, 7]);


                        Console.SetCursorPosition(64, 21);
                        Console.Write("      PROCEED TO THE NEXT LEVEL?: ");
                        string _level = Console.ReadLine().ToUpper();
                   

                        while( _level != "YES" || _level != "Y")
                        {
                        FitnessRecord();
                        break;
                        }
                        

                        


                        if (_level == "YES" || _level == "Y" || _level == "y")
                        {
                        string fitness_type;

                            Console.SetCursorPosition(64, 22);
                            Console.WriteLine("      CHOOSE FITNESS PROGRAM LEVEL");
                            Console.SetCursorPosition(64, 23);
                            Console.WriteLine("      1. BEGINNER");
                            Console.SetCursorPosition(64, 24);
                            Console.WriteLine("      2. INTERMIDIATE");
                            Console.SetCursorPosition(64, 25);
                            Console.WriteLine("      3. ADVANCE");
                            Console.SetCursorPosition(64, 26);
                            Console.Write("      CHOICE: ");
                            string choice = Console.ReadLine();

                            if (choice == "1")
                            {
                                fitness_type = "BEGINNER";

                                if (fitness_type == Membership_profile[idx, 7])
                                       Console.WriteLine("You have selected the current Fitness Program");  
                                if (Membership_profile[idx, 7] == "INTERMIDIATE")
                                       Console.WriteLine("Current Fitness Level is INTERMIDIATE LEVEl. You cannot go back to BEGINNER LEVEL");
                                if (Membership_profile[idx, 7] == "ADVANCE")
                                       Console.WriteLine("Current Fitness Level is ADVANCE LEVEl. You cannot go back to BEGINNER LEVEL");
                            }

                            else if (choice == "2")
                            {
                                fitness_type = "INTERMIDIATE";

                                if (fitness_type == Membership_profile[idx, 7])
                                       Console.WriteLine("You have selected the current Fitness Program");
                                if (Membership_profile[idx,7] == "BEGINNER")
                                  {
                                       Membership_profile[idx, 7] = "INTERMIDIATE";
                                       Console.WriteLine(" Fitness Program Level Upgraded...");
                                  }
                                if (Membership_profile[idx, 7] == "ADVANCE")
                                       Console.WriteLine("Current Fitness Level is ADVANCE LEVEl. You cannot go back to INTERMIDIATE LEVEL");
                                


                             }
                            else if (choice == "3")
                            {

                                fitness_type = "ADVANCE";

                                 if (fitness_type == Membership_profile[idx, 7])
                                         Console.WriteLine("You have selected the current Fitness Program");
                                 if (Membership_profile[idx,7] == "INTERMIDIATE")
                                  {
                                       Membership_profile[idx, 7] = "ADVANCE";
                                         Console.WriteLine(" Fitness Program Level Upgraded...");
                                  }
                                 if (Membership_profile[idx, 7] == "BEGINNER")
                                         Console.WriteLine("Current Fitness Level is ADVANCE LEVEl. You cannot go back to BEGINNER LEVEL");

                                 if (Membership_profile[idx, 7] == "INTERMIDIATE")
                                         Console.WriteLine("Current Fitness Level is ADVANCE LEVEl. You cannot go back to INTERMIDIATE LEVEL");
                        }
                    }
                        else
                        {
                            Console.SetCursorPosition(64, 23);
                            Console.WriteLine("      Keep up the good work.");
                        }
                        Console.SetCursorPosition(64, 27);
                        Console.Write("      DO YOU WANT TO TRY AGAIN?: ");
                        ans = Console.ReadLine().ToUpper();

                        while (ans != "YES" && ans != "Y" && ans != "NO" && ans != "N")
                        {
                            Console.WriteLine("WRONG INPUT!! TRY AGAIN");
                            Console.Write("DO YOU WANT TO TRY AGAIN?: ");
                            ans = Console.ReadLine().ToUpper();
                        }

                    } while (ans == "YES" || ans == "Y");

                }
            }
            static void walkin()
            {
                Console.Clear();
                Console.SetCursorPosition(60, 5);
                Console.Write("INPUT FULL NAME: ");
                string fname = Console.ReadLine().ToUpper();
                int id = -1;

                for (int j = 0; j < WalkIn_profile.GetLength(1); j++)

                {
                    if (fname.ToUpper() == WalkIn_profile[j, 0].ToUpper())
                    {
                        id = j;
                        break;
                    }
                }
                if (id == -1)
                {
                    Console.WriteLine("Sorry no information found.");
                }

                else
                {
                    string ans = "";
                    do
                    {
                        Console.Clear();
                        Console.SetCursorPosition(78, 1);
                        Console.WriteLine("WALK-IN");
                        Console.SetCursorPosition(75, 2);
                        Console.WriteLine("INFORMATION FOUND");
                        Console.SetCursorPosition(58, 3);
                        Console.WriteLine("\t---------------------------------------");
                        Console.SetCursorPosition(60, 5);
                        Console.WriteLine("\t\t     NAME      : {0}", WalkIn_profile[id, 0]);
                        Console.SetCursorPosition(60, 7);
                        Console.WriteLine("\t\t     AGE       : {0}", WalkIn_profile[id, 1]);
                        Console.SetCursorPosition(60, 9);
                        Console.WriteLine("\t\t     GENDER    : {0}", WalkIn_profile[id, 2]);
                        Console.SetCursorPosition(60, 11);
                        Console.WriteLine("\t\t     ADDRESS   : {0}", WalkIn_profile[id, 3]);
                        Console.SetCursorPosition(60, 13);
                        Console.WriteLine("\t\t     CONTACT # : {0}", WalkIn_profile[id, 4]);
                        Console.SetCursorPosition(60, 15);
                        Console.WriteLine("\t\t     TYPE      : {0}", WalkIn_profile[id, 5]);
                        Console.SetCursorPosition(60, 17);
                        Console.WriteLine("\t\t     MONEY     : {0}", WalkIn_profile[id, 6]);
                        Console.SetCursorPosition(60, 19);
                        Console.WriteLine("\t\t     LEVEL     : {0}", lev[id]);

                        Console.SetCursorPosition(64, 21);
                        Console.Write("     INPUT WORK OUT LEVEL?: ");
                        string _level = Console.ReadLine().ToUpper();
                        if (_level == "YES" || _level == "Y")
                        {
                            Console.SetCursorPosition(64, 22);
                            Console.WriteLine("      CHOOSE FITNESS PROGRAM LEVEL");
                            Console.SetCursorPosition(64, 23);
                            Console.WriteLine("      1. BEGINNER");
                            Console.SetCursorPosition(64, 24);
                            Console.WriteLine("      2. INTERMIDIATE");
                            Console.SetCursorPosition(64, 25);
                            Console.WriteLine("      3. ADVANCE");
                            Console.SetCursorPosition(64, 26);
                            Console.Write("      CHOICE: ");
                            string choice = Console.ReadLine();
                            if (choice == "1")
                            {
                                lev[id] = "BEGINNER";
                            }
                            else if (choice == "2")
                            {
                                lev[id] = "INTERMIDIATE";
                            }
                            else if (choice == "3")
                            {
                                lev[id] = "ADVANCE";
                            }
                        }
                        else
                        {
                            Console.SetCursorPosition(64, 23);
                            Console.WriteLine("      Keep up the good work.");
                        }
                        Console.SetCursorPosition(64, 27);
                        Console.Write("      DO YOU WANT TO TRY AGAIN?: ");
                        ans = Console.ReadLine().ToUpper();
                        while (ans != "YES" && ans != "Y" && ans != "NO" && ans != "N")
                        {
                            Console.WriteLine("WRONG INPUT!! TRY AGAIN");
                            Console.Write("DO YOU WANT TO TRY AGAIN?: ");
                            ans = Console.ReadLine().ToUpper();
                        }
                    } while (ans == "YES" || ans == "Y");
                }
            }
            static void Exit()
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t╔═════════════════════════════════════════════════╗");
                Console.WriteLine("\t\t\t\t\t\t\t║                                                 ║");
                Console.WriteLine("\t\t\t\t\t\t\t║                                                 ║");
                Console.WriteLine("\t\t\t\t\t\t\t║             Thank you for using our             ║");
                Console.WriteLine("\t\t\t\t\t\t\t║                     program.                    ║");
                Console.WriteLine("\t\t\t\t\t\t\t║                                                 ║");
                Console.WriteLine("\t\t\t\t\t\t\t║                     Goodbye!                    ║");
                Console.WriteLine("\t\t\t\t\t\t\t║                                                 ║");
                Console.WriteLine("\t\t\t\t\t\t\t║                                                 ║");
                Console.WriteLine("\t\t\t\t\t\t\t╚═════════════════════════════════════════════════╝");
                Thread.Sleep(1000);
                Environment.Exit(0);
                Console.ReadLine();
            }
        }
    }
