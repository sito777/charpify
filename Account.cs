using System;

namespace Spotify_App
{

	public class Account
	{
        public string? accountName;
        public List<string> friends = new List<string>();
        public List<string> playlist = new List<string>();

        public void showFriends()
        {
            foreach (string x in friends)
            {
                Console.WriteLine(x);
            };
        }

        public void showPlaylists()
        {
            foreach (string x in playlist)
            {
                Console.WriteLine(x);
            };
        }

        public void addFriends()
        {
            Console.WriteLine("\nType the name of your friends. When you are done type 'exit' ");
            Boolean addFriendBool = true;
            while (addFriendBool)
            {
                string friend = Console.ReadLine();
                if (friend.ToLower() != "exit")
                {
                    this.friends.Add(friend);
                }
                else
                {
                    addFriendBool = false;

                }

            }
        }

        public void accountInfoOptions()
        {
            Console.WriteLine("\nWhat do you want to see of your account " + accountName + "?" +
                "\n1. Account name" +
                "\n2. Friends" +
                "\n3. Playlists" +
                "\n4. Skip this menu");
            int input = Int32.Parse(s: Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("\nYou currently logged in the account of " + accountName);
                    break;
                case 2:
                    Console.WriteLine("\nFriendlist:");
                    showFriends();
                    break;
                case 3:
                    Console.WriteLine("\nPlaylists:");
                    showPlaylists();

                    //Console.WriteLine("\nDo you want to open an playlist?\n1. Yes\n2.No");
                    //int openPlaylist = Int32.Parse(s: Console.ReadLine());
                    //if (openPlaylist == 1)
                    //{
                    //    Console.WriteLine("\nWhich playlist would you like to open?\nType the title");
                    //    string seePlaylist = Console.ReadLine();

                    //}

                    break;
                case 4:
                    break;

            }
        }

    }
}

