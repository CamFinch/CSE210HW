using System;

class Program
{
    static void Main(string[] args)
    {
        Video vid1 = new Video();
        Video vid2 = new Video();
        Video vid3 = new Video();
        Video vid4 = new Video();
        Comment comment1 = new Comment();
        Comment comment2 = new Comment();
        Comment comment3 = new Comment();
        Comment comment4 = new Comment();
        Comment comment5 = new Comment();
        Comment comment6 = new Comment();
        Comment comment7 = new Comment();
        Comment comment8 = new Comment();
        Comment comment9 = new Comment();
        Comment comment10 = new Comment();
        Comment comment11 = new Comment();
        Comment comment12 = new Comment();

        /////////////////Videos//////////////////////////////

        vid1._title = "How To Tie Your Shoes";
        vid1._author = "James King";
        vid1._length = 80;
        

        vid2._title = "The 7 Wonders of the World";
        vid2._author = "Percy Knight";
        vid2._length = 160;


        vid3._title = "Making The Eiffel Tower Out Of Chocolate";
        vid3._author = "Bob Keith";
        vid3._length = 400;


        vid4._title = "How To Make A Song";
        vid4._author = "Korth Flack";
        vid4._length = 345;

        ///////////////////Comments/////////////////////////////

        comment1._username = "thelegend27";
        comment1._message = "Great Video! Very Informative!\n";
        comment2._username = "king1223";
        comment2._message = "Cool Vid!\n";
        comment3._username = "coolguy72";
        comment3._message = "Thanks For Sharing!\n";

        comment4._username = "bob123";
        comment4._message = "Awesome Bro!\n";
        comment5._username = "kyle3423";
        comment5._message = "Nice Vid\n";
        comment6._username = "jim342";
        comment6._message = "I really enjoyed this vid!\n";

        comment7._username = "tobi87";
        comment7._message = "I love chocolate\n";
        comment8._username = "paul983";
        comment8._message = "How is this possible?\n";
        comment9._username = "cam324";
        comment9._message = "Amazign!\n";

        comment10._username = "kim423";
        comment10._message = "I love music!\n";
        comment11._username = "tay123";
        comment11._message = "Sounds amazing!\n";
        comment12._username = "simon5456";
        comment12._message = "Thanks for sharing!\n";

        /////////////////Add To List/////////////////////////////

        vid1._comments.Add(comment1);
        vid1._comments.Add(comment2);
        vid1._comments.Add(comment3);

        vid2._comments.Add(comment4);
        vid2._comments.Add(comment5);
        vid2._comments.Add(comment6);

        vid3._comments.Add(comment7);
        vid3._comments.Add(comment8);
        vid3._comments.Add(comment9);

        vid4._comments.Add(comment10);
        vid4._comments.Add(comment11);
        vid4._comments.Add(comment12);
        ////////////////Display///////////////////////////////////

        vid1.DisplayVideo();
        comment1.DisplayComment();

        vid2.DisplayVideo();
        comment4.DisplayComment();

        vid3.DisplayVideo();
        comment5.DisplayComment();

        vid4.DisplayVideo();
        comment10.DisplayComment();

    }
}