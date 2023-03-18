using System;

class Program
{
    static void Main(string[] args)
    {


        //string title, string description, string address, string date, string time, string speakerName, int capacity, string lType
        Lecture lecture1 = new Lecture("ALL ABOUT SPACE", "LEARN ABOUT STARS AND GALAXIES", "BYUI ROOM 608", "MARCH 1", "8PM", "Cameron Finch", 50, "LECTURE");
        Console.WriteLine("\n-----------FULL DETAILS------------\n");
        Console.WriteLine(lecture1.StandardDetials());
        Console.WriteLine(lecture1.GetLectureInfo());

        //string title, string description, string address, string date, string time, string email, string rType
        Reception r1 = new Reception("JAY AND KATES WEDDING RECEPTION", "Please rsvp to the reception by march 31", "16 Road 6723, Fruitland NM", "APRIL 3", "6PM", "cameron@gmail.com", "RECEPTION");
        Console.WriteLine("\n-----------FULL DETAILS------------\n");
        Console.WriteLine(r1.StandardDetials());
        Console.WriteLine(r1.GetEmail());

        //string title, string description, string address, string date. string time, string weather, string oType
        Outdoor outdoor1 = new Outdoor("CAMPING TRIP", "CAMPING AT BERG PARK", "784 Road 6534 FARMINGTON NM", "MARCH 31", "11AM", "CLOUDY", "OUTDOOR");
        Console.WriteLine("\n-----------FULL DETAILS------------\n");
        Console.WriteLine(outdoor1.StandardDetials());
        Console.WriteLine(outdoor1.GetWeather());

        //string title, string description, string address, string date, string time
        Console.WriteLine("\n-----------STANDARD DETAILS------------\n");
        Event eLecture = new Event("HISTORY OF THE MONGOL EMPIRE", "LEARN ALL ABOUT THE MONGOL EMPIRE", "BYUI ROOM 143", "APRIL 9", "9AM");
        Console.WriteLine(eLecture.StandardDetials());

        Console.WriteLine("\n-----------STANDARD DETAILS------------\n");
        Event rLecture = new Event("KIM AND BRAD ANNIVERSARY", "COME AND JOIN US FOR KIM AND BRADS 10TH ANNIVERSARY", "672 Road 8723, FARMINGTON NM", "APRIL 7", "6PM");
        Console.WriteLine(rLecture.StandardDetials());

        Console.WriteLine("\n-----------STANDARD DETAILS------------\n"); 
        Event oLecture = new Event("PICNIC AT GARDEN SQUARE", "COME JOIN US FOR A PICNIC", "823 Road 7645, FARMINGTON NM", "JUNE 8", "12PM");
        Console.WriteLine(oLecture.StandardDetials());

        // TYPE, TITLE, DATE
        Console.WriteLine("\n------------SHORT DETAILS------------");
        Lecture lecture2 = new Lecture("ALL ABOUT SPACE", "LEARN ABOUT STARS AND GALAXIES", "BYUI ROOM 608", "MARCH 1", "8PM", "Cameron Finch", 50, "LECTURE");
        Console.WriteLine(lecture2.ShortDetails());
        Console.WriteLine(lecture2.ShortLecture());

        Console.WriteLine("\n------------SHORT DETAILS------------");
        Reception r2 = new Reception("JAY AND KATES WEDDING RECEPTION", "Please rsvp to the reception by march 31", "16 Road 6723, Fruitland NM", "APRIL 3", "6PM", "cameron@gmail.com", "RECEPTION");
        Console.WriteLine(r2.ShortDetails());
        Console.WriteLine(r2.ShortReception());

        Console.WriteLine("\n------------SHORT DETAILS------------");
        Outdoor outdoor2 = new Outdoor("CAMPING TRIP", "CAMPING AT BERG PARK", "784 Road 6534 FARMINGTON NM", "MARCH 31", "11AM", "CLOUDY", "OUTDOOR");
        Console.WriteLine(outdoor2.ShortDetails());
        Console.WriteLine(outdoor2.ShortOutdoor());
    }

}