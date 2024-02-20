using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;


class Program
{
    static void Main(string[] args)
    {
        // Welcome message
        Clear();
        Console.WriteLine("\n Youtube Video Tracking App");
        Console.WriteLine("\nPress any key to see video data...");
        ReadKey();

        // First Video
        Video video1 = new Video("Recipe for Coconut-filled Chocolate Bounty Cupcakes", "Cupcake Jemma", 716);
        video1.AddComment("@laurenmick", "\nYum! The transition between the ganache and the buttercream looks like toasted coconut!");
        video1.AddComment("@10zaralove", "\nDane is a fabulous baker and those cakes look incredible, but how beautiful does Dane look...! Stunner!");
        video1.AddComment("@Miekzz", "\nDane's such a master, the speed and precision with which he works are amazing to watch");
        video1.AddComment("@ravika", "\nI have been looking for a bounty cake recipe for years! I am so happy! Cannot wait to make these! Thank you!");

        // Second Video
        Video video2 = new Video("The Best New York Style Chocolate Chip Cookies", "Cupcake Jemma", 616);
        video2.AddComment("@xXxmissemmaxXx", "\nI adore Sally! She’s so easy breezy in the way she teaches, if that makes sense. Quick and to the point without rushing. 💜");
        video2.AddComment("@bethanymegan9811", "\nI followed this recipe, but used 3 bars of Lindt chocolate and smashed them up into chunks (1 dark with sea salt, 2 60% milk) and they turned out INCREDIBLE. Thank you for sharing!!");
        video2.AddComment("@leannechapman6372", "\nI can wholeheartedly say this is by far the best cookie recipe! If you're debating whether to bake these cookies let me assure you that you will not regret it! They are fantastic. Thank you so much for the recipe!");
        video2.AddComment("@passiveagressive4983", "\nI made these straight away and have to say, the best I’ve ever had in my life!");

        // Third Video
        Video video3 = new Video("How to Bake a Heart Inside a Cupcake ", "Cupcake Jemma", 607);
        video3.AddComment("@garydaniels5662", "\nClever, easy when you know how, wasn't expecting the heart to be previously baked, Thank you for sharing.");
        video3.AddComment("@kwintinafiles6367", "\nWonderful and cutest Valentine's cupcake idea Jemma!!! Wow!! I love these and I know they're delicious too! Happy Valentine's Day, Beautiful! 🥰");
        video3.AddComment("@cgreene1000", "\nLovely! Thank you for revealing how to do this. I have seen heart cupcakes on Pinterest and have always wondered what the mystery was behind it. Awesome!");
        video3.AddComment("@anjula9110", "\nI made this today 14 Feb 2020 and awesome...my hubby loved them. Thank you Jemma for the lovely reciepe 🥰♥️");

        // Fourth Video
        Video video4 = new Video("Cute Unicorn Cupcakes with Magic Horns and Ears! ", "Cupcake Jemma", 414);
        video4.AddComment("@debbylev", "\nThank you so much for always sharing so generously! Your recipes and ideas and creativity!  Love watching and learning form you!  Lots of continued success!");
        video4.AddComment("@jenniferwu4655", "\nHow adorable! The little ears definitely made the cupcakes even more lovable!");
        video4.AddComment("@niccishepherd8410", "\nThat trick with putting the 3 colors together on the saran wrap and putting that in the piping bag is GENIUS!! :D");
        video4.AddComment("@tanyastille5536", "\nI love watching you create cupcakes and cakes. You make it look so simple.");

        //Create a list of videos entered
        List<Video> _videos = new List<Video> {video1, video2, video3, video4};


        //Iterate through list of videos to display info and number each video
        int i = 1;
        foreach (Video v in _videos)
        {
            Clear();
            Console.WriteLine($"\nVideo {i}");
            i += 1;
            v.DisplayVideo();
                
            Console.WriteLine("\nComments:");
            foreach (Comment c in v._comments)
            {
                c.DisplayComments();
                Console.WriteLine("");
            }

            //Waits for user to press key before showing next video data
            Console.Write("\nPress any key to see next video...\n\n");
            ReadKey();
        }
    }
}