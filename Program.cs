using System;

namespace Spotify_App
{

    class Program
    {
        static void Main(string[] args)
        {
            void helpMenu()
            {
                Console.WriteLine("What do you want to do next?" +
                    "\n1. See my friends" +
                    "\n2. See my playlists" +
                    "\n3. Add friends" +
                    "\n4. Make a new playlist" +
                    "\n5. Logout" +
                    "\n6. exit Charpify");
            }

            Account johnDoe = new Account();
            johnDoe.accountName = "John Doe";
            johnDoe.friends.Add("Joker");
            johnDoe.friends.Add("Elon");
            johnDoe.friends.Add("Satoshi");
            johnDoe.friends.Add("Bol");
            johnDoe.friends.Add("Axcel");
            johnDoe.playlist.Add("summer hits");
            johnDoe.playlist.Add("top 50 of 2022");
            johnDoe.playlist.Add("dance");
            johnDoe.playlist.Add("Move like jagger");

            Track abc = new Track();
            abc.titleTrack = "ABC";
            abc.genre = "Pop";
            abc.artist = "Jan kooi";
            abc.featurings.Add("Peter");
            abc.featurings.Add("Afro Jack");
            abc.featurings.Add("Martin");

            Track acdc = new Track();
            acdc.titleTrack = "acdc";
            acdc.genre = "Rock";
            acdc.artist = "Kelly Price";
            acdc.featurings.Add("Offset");

            Album theFive = new Album();
            theFive.albumDuration = 300;
            theFive.artistAlbum = "Micheal Jackson";
            theFive.albumName = "The 5";
            theFive.tracks.Add("Little Micheal");
            theFive.tracks.Add("Big Micheal");
            theFive.tracks.Add("Big Micheal");

            Boolean appAlwaysOn = true;
            while (appAlwaysOn) {
                Console.WriteLine("\nWelcome by Charpify! \nType a number to choose an option\n1. Log in with " + johnDoe.accountName +
                    ".\n2. Make account" +
                    "\n3. Exit Charpify");

                int welcomeUser = Int32.Parse(s: Console.ReadLine());
                switch (welcomeUser)
                {
                    case 1:
                        Console.WriteLine("\nWelcome " + johnDoe.accountName);

                        Boolean caseOne = true;
                        while (caseOne)
                        {
                            helpMenu();
                            int menuOption = Int32.Parse(s: Console.ReadLine());
                            switch (menuOption)
                            {
                                case 1:
                                    johnDoe.showFriends();
                                    break;
                                case 2:
                                    johnDoe.showPlaylists();
                                    break;
                                case 3:
                                    johnDoe.addFriends();
                                    break;
                                case 4:
                                    Console.WriteLine("\nthis Function is under construction");
                                    break;
                                case 5:
                                    caseOne = false; 
                                    break;
                                case 6:
                                    caseOne = false;
                                    appAlwaysOn = false;
                                    break;
                            }
                        }

                        Console.Clear();
                        break;
                    //end case 1

                    case 2:
                        Console.WriteLine("\nWhat is your name?");
                        string accName = Console.ReadLine();
                        Account accountOne = new Account() { accountName = accName};

                        Console.WriteLine("\nDo you want to add friends? type 'yes' or 'no'");
                        string addfriends = Console.ReadLine().ToLower();
                        if(addfriends == "yes")
                        {
                            accountOne.addFriends();
                        }

                        Boolean caseTwo = true;
                        while (caseTwo)
                        {
                            helpMenu();
                            int menuOption = Int32.Parse(s: Console.ReadLine());
                            switch (menuOption)
                            {
                                case 1:
                                    accountOne.showFriends();
                                    break;
                                case 2:
                                    accountOne.showPlaylists();
                                    break;
                                case 3:
                                    accountOne.addFriends();
                                    break;
                                case 4:
                                    Console.WriteLine("\nthis Function is under construction");
                                    break;
                                case 5:
                                    caseTwo = false;
                                    break;
                                case 6:
                                    caseTwo = false;
                                    appAlwaysOn = false;
                                    break;
                            }
                        }

                        Console.Clear();
                        break;
                    //end case 2


                    case 3:
                        appAlwaysOn = false;
                        Console.Clear();
                        Console.WriteLine("Goodby!");
                        break;
                    //end case 3

                }
            }
        }
    }
}
