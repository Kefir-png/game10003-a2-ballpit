// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    
    public class Game
    {
        float playerMouse;
        Color circleColor;

        public void Setup()
        {
            Window.SetSize(200, 200);
            Window.SetTitle("Kalimba Keys");
        }

        public void Update()
        {
            Window.ClearBackground(Color.Gray);
            Circle1();
            Circle2();
            Circle3();  
            Circle4();
            Circle5();
            playerMouse = Input.GetMouseX();
            circleColor = Random.Color();
        }

        public void Circle1() 
        {
            if (playerMouse <=20 && playerMouse >=0)
            {
                Draw.FillColor = circleColor;
                Draw.LineColor = Color.Black;
                Draw.Circle(10, 50, 5);
            }
            else
            {
                Draw.FillColor = Color.Gray;
                Draw.LineColor = Color.Black;
                Draw.Circle(10, 50, 5);
            }
        }

        public void Circle2()
        {
            if (playerMouse <= 40 && playerMouse >= 20)
            {
                Draw.FillColor = circleColor;
                Draw.LineColor = Color.Black;
                Draw.Circle(30, 50, 5);
            }
            else
            {
                Draw.FillColor = Color.Gray;
                Draw.LineColor = Color.Black;
                Draw.Circle(30, 50, 5);
            }
        }

        public void Circle3()
        {
            if (playerMouse <= 60 && playerMouse >= 40)
            {
                Draw.FillColor = circleColor;
                Draw.LineColor = Color.Black;
                Draw.Circle(50, 50, 5);
            }
            else
            {
                Draw.FillColor = Color.Gray;
                Draw.LineColor = Color.Black;
                Draw.Circle(50, 50, 5);
            }
        }

        public void Circle4()
        {
            if (playerMouse <= 80 && playerMouse >= 60)
            {
                Draw.FillColor = circleColor;
                Draw.LineColor = Color.Black;
                Draw.Circle(70, 50, 5);
            }
            else
            {
                Draw.FillColor = Color.Gray;
                Draw.LineColor = Color.Black;
                Draw.Circle(70, 50, 5);
            }
        }

        public void Circle5()
        {
            if (playerMouse <= 100 && playerMouse >= 80)
            {
                Draw.FillColor = circleColor;
                Draw.LineColor = Color.Black;
                Draw.Circle(90, 50, 5);
            }
            else
            {
                Draw.FillColor = Color.Gray;
                Draw.LineColor = Color.Black;
                Draw.Circle(90, 50, 5);
            }
        }

    }
}


//Iv been having issues with the window size. 100x100 cant funtion prperly and reorients my circle positions to the side and so i have to upscale the entire 
//window to 200x200 in oder for it to look the way i want. Ill also update it to look like piano keys. So next push ill be change the circles into rectangles and
//reorganize my color changing shapes.