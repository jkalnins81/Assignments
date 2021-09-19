using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment2Extra1 : ProcessingLite.GP21
{
    float spaceBetweenLines = 0.2f;

    void Update()
    {
        //Clear background
        Background(50, 166, 240);

        //Draw our art, or in this case a rectangle
        Rect(1, 1, 3, 3);

        Stroke(128, 128, 128, 64);
        StrokeWeight(0.5f);

            
            //Draw our scan lines
            for (int i = 0; i < Width / spaceBetweenLines; i++)
            {
            //Increase y-cord each time loop run
            float x = i * spaceBetweenLines;



            //Draw a line from left side of screen to the right
            //this time modify the height depending on time passed
            
            Line((x + Time.time) % Width, 0, (x + Time.time) % Width, Height);

        }
    }
}
