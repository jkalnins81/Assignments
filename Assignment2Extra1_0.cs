using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment2Extra1_0 : ProcessingLite.GP21
{
    // standard Animations script as per: https://github.com/yrgo/gp21/tree/master/Programming%20Fundamentals/02%20-%20Learning%20to%20Program

    float spaceBetweenLines = 0.2f;

    void Start()
    {
    }

    void Update()
    {
        //Clear background
        Background(50, 166, 240);

        //Draw our art, or in this case a rectangle
        Rect(1, 1, 3, 3);

        Stroke(128, 128, 128, 64);
        StrokeWeight(0.5f);

        //Draw our scan lines
        for (int i = 0; i < Height / spaceBetweenLines; i++)
        {
            //Increase y-cord each time loop run
            float y = i * spaceBetweenLines;

            //Draw a line from left side of screen to the right
            //this time modify the height depending on time passed
            Line(0, (y + Time.time) % Height, Width, (y + Time.time) % Height);
        }
    }
}
