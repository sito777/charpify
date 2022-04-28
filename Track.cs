using System;

namespace Spotify_App
{

	public class Track
	{
        public string? titleTrack;
        public string? artist;
        public string? genre;
        public List<string> featurings = new List<string>();
        public double trackDuration;


        public void TrackInfoOptions()
        {
            Console.WriteLine("\nWhat do you want the know about the track " + titleTrack + "?.\n1. Track name\n2. Artist\n3. Genre\n4. Features\n5. Track duration\n6. Everything");
            int input = Int32.Parse(s: Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("\nTrack: " + titleTrack);
                    break;
                case 2:
                    Console.WriteLine("\nArtist: " + artist);
                    break;
                case 3:
                    Console.WriteLine("\nGenre: " + genre);
                    break;
                case 4:
                    Console.Write("\nFeaturing: ");
                    foreach (string x in featurings)
                    {
                        Console.Write(x + ", ");

                    };
                    break;
                case 5:
                    Console.WriteLine("\n" + titleTrack + "has a duration of " + trackDuration + " minutes");
                    break;
                case 6:
                    Console.Write("\nThis is the track of " + artist + " By " + titleTrack + " \nGenre: " + genre + "\nTime: " + trackDuration + "\nfeaturing: ");
                    foreach (string x in featurings)
                    {
                          Console.Write(x + ", ");
                    };
                    break;

            }
        }

    }
}

