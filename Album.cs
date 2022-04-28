using System;

namespace Spotify_App
{

	public class Album
	{
        public string? albumName;
        public string? artistAlbum;
        public string? genre;
        public List<string> tracks = new List<string>();
        public double albumDuration;



        public void AlbumInfoOptions()
            {
                Console.WriteLine("\nWhat do you want the know about the Album " + albumName + "?.\n1. Name\n2. Artist\n3. Genre\n4. Tracks\n5. Album duration\n6. Everything");
                int input = Int32.Parse(s: Console.ReadLine());
                
                switch (input)
                {
                case 1:
                    Console.WriteLine("\nAlbum name: " + albumName);
                    break;
                case 2:
                    Console.WriteLine("\nArtist: "+ artistAlbum);
                    break;
                case 3:
                    Console.WriteLine("\nGenre: " + genre);
                    break;
                case 4:
                    Console.Write("\nTracks: ");
                    foreach (string x in tracks)
                    {
                        Console.Write(x + ", ");
                    };
                    break;
                case 5:
                    Console.WriteLine("\n" + albumName + " has a duration of " + albumDuration + " minutes");
                    break;
                case 6:
                    Console.Write("\nThis is the album of " + artistAlbum + " By " + albumName + " \nGenre: " + genre + "\nTime: " + albumDuration + "\ntracks: ");
                    foreach (string x in tracks)
                    {
                        Console.Write(x + ", ");
                    };
                    break;

                }
            }

    }
}

