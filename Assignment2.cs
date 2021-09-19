using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment2 : ProcessingLite.GP21
{
    // Assignment på: https://github.com/yrgo/gp21/tree/master/Programming%20Fundamentals/02%20-%20Learning%20to%20Program
    // Answer to question 4. It limits the values to between the min & max so that they do not go outside of this range. This could occur if the values are changed via script, manually in the inspector, or if a function occurs it to change to a value outside of the min or max.


    public float xStartPoint;
    public float yStartPoint;
    public float xEndPoint;
    public float yEndPoint;


    // Start is called before the first frame update
    void Start()
    {
        // need 10 lines for a parabolic curve as per: https://www.wikihow.com/Draw-a-Parabolic-Curve-(a-Curve-with-Straight-Lines)

        Background(255, 252, 252); // make background white
        LoopParabolicCurve();

    }


    void LoopParabolicCurve()
    {
        for (int i = 0; i < 11; i++)
        {
            if (i % 3 == 0)
            {
                Stroke(12, 12, 13); // make lines black
                DrawLine();
                
            }

            else
            {
                Stroke(109, 109, 111); // makes lines grey
                DrawLine();
            }

            


        }

       
    }

    void DrawLine()
    {
        Line(xStartPoint, yStartPoint, xEndPoint, yEndPoint); // where xStartPoint = 0, ,yStartPoint = 11, xEndPoint = 0, yEndPoint = 0

        yStartPoint = yStartPoint - 1;
        xEndPoint = xEndPoint + 1;
    }

    

    // Update is called once per frame
    void Update()
    {
        

        

    }
}
