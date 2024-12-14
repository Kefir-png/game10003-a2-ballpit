// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;

// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    //This is just where all my game code is...
    public class Game
    {
        //Setting some variables for future workings.
        float playerMouse;
        Color rectangleColor;

        //This is set up, where iv set the size of the window and its name.
        public void Setup()
        {
            Window.SetSize(200, 200);
            Window.SetTitle("Kalimba Keys");
        }

        //In the update is set up a bunch of call functions that call to a function that controls the "kalimba keys" on screen.
        //Each one controls one key and updates every frame checking if it is in the path of the cursor.
        //Player mouse coords are also taken here and constanly updated. 
        //"rectangleColor = Random.Color" is in here pecifically because i want it to change the color every frame.
        //When i defined it outside of Update it kept the same color when i loaded the game.
        public void Update()
        {
            Key1();
            Key2();
            Key3();
            Key4();
            Key5();
            playerMouse = Input.GetMouseX();
            rectangleColor = Random.Color();
        }

        //Its basically the exact same in each call function the only change is the coordinates and if statement requirements for the playerMouse X position are diffrent.
        public void Key1()
        {
            if (playerMouse <= 40 && playerMouse >= 0)
            {
                Draw.FillColor = rectangleColor;
                Draw.LineColor = Color.Black;
                Draw.LineSize = 4;
                Draw.Rectangle(0, 0, 45, 200);
            }
            else
            {
                Draw.FillColor = Color.Gray;
                Draw.LineColor = Color.Black;
                Draw.LineSize = 4;
                Draw.Rectangle(0, 0, 45, 200);
            }
        }

        public void Key2()
        {
            if (playerMouse <= 80 && playerMouse >= 40)
            {
                Draw.FillColor = rectangleColor;
                Draw.LineColor = Color.Black;
                Draw.LineSize = 4;
                Draw.Rectangle(40, 0, 80, 200);

            }
            else
            {
                Draw.FillColor = Color.Gray;
                Draw.LineColor = Color.Black;
                Draw.LineSize = 4;
                Draw.Rectangle(40, 0, 80, 200);

            }
        }

        public void Key3()
        {
            if (playerMouse <= 120 && playerMouse >= 80)
            {
                Draw.FillColor = rectangleColor;
                Draw.LineColor = Color.Black;
                Draw.LineSize = 4;
                Draw.Rectangle(80, 0, 120, 200);

            }
            else
            {
                Draw.FillColor = Color.Gray;
                Draw.LineColor = Color.Black;
                Draw.LineSize = 4;
                Draw.Rectangle(80, 0, 120, 200);

            }
        }

        public void Key4()
        {
            if (playerMouse <= 160 && playerMouse >= 120)
            {
                Draw.FillColor = rectangleColor;
                Draw.LineColor = Color.Black;
                Draw.LineSize = 4;
                Draw.Rectangle(120, 0, 160, 200);

            }
            else
            {
                Draw.FillColor = Color.Gray;
                Draw.LineColor = Color.Black;
                Draw.LineSize = 4;
                Draw.Rectangle(120, 0, 160, 200);

            }
        }

        public void Key5()
        {
            if (playerMouse <= 200 && playerMouse >= 160)
            {
                Draw.FillColor = rectangleColor;
                Draw.LineColor = Color.Black;
                Draw.LineSize = 4;
                Draw.Rectangle(160, 0, 200, 200);

            }
            else
            {
                Draw.FillColor = Color.Gray;
                Draw.LineColor = Color.Black;
                Draw.LineSize = 4;
                Draw.Rectangle(160, 0, 200, 200);

            }
        }

    }
}


//In this commit i changed the circles into rectangels.And also quadroople chacked the rubric for this assignment. Ill also have to change the name of the file and git stuff.
//Oh also adding coherent comments and changing anything called "circle" into "key" or somthing like on piano so it makes sense.


//Itll show up in git as me rewriting everything in this code but i just had issues with git earlier and so i ended up copy pasteing from another file where a later version of this 
//project got lost...