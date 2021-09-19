using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParabolicCurves : ProcessingLite.GP21
{

    // use the following as variables to create any parabolic curve: axis1, axis2, numberOfLines.

    public Vector2 parabolicCurve1Axis1Start; // Start point (x, y)
    public Vector2 parabolicCurve1Axis2End; // End point (x, y)

    public Vector2 parabolicCurve2Axis1Start;
    public Vector2 parabolicCurve2Axis2End;

    public Vector2 parabolicCurve3Axis1Start;
    public Vector2 parabolicCurve3Axis2End;

    public float parbolicCurve1NumberOfLines;
    public float parbolicCurve2NumberOfLines;
    public float parbolicCurve3NumberOfLines;
    
    public Color background;
    
    int rColor;
    int gColor;
    int bColor;
       
    void Start()
    {
        Background(background); // make background white
        
        ParabolicCurve1();
        ParabolicCurve2();
        ParabolicCurve3();

    }

    

    void ParabolicCurve1()
    {
        for (int i = 0; i < parbolicCurve1NumberOfLines; i++)
        {
            if (i % 11 == 0)
            {
                RandomColorGenerator();

                Stroke(rColor, gColor, bColor); // make lines black

                DrawParabolicLine1();

            }

            if (i % 10 == 0)
            {
                RandomColorGenerator();

                Stroke(rColor, gColor, bColor); // make lines black

                DrawParabolicLine1();

            }

            if (i % 9 == 0)
            {
                RandomColorGenerator();

                Stroke(rColor, gColor, bColor); // make lines black

                DrawParabolicLine1();

            }

            if (i % 8 == 0)
            {
                RandomColorGenerator();

                Stroke(rColor, gColor, bColor); // make lines black

                DrawParabolicLine1();

            }

            if (i % 7 == 0)
            {
                RandomColorGenerator();

                Stroke(rColor, gColor, bColor); // make lines black

                DrawParabolicLine1();

            }

            if (i % 6 == 0)
            {
                RandomColorGenerator();

                Stroke(rColor, gColor, bColor); // make lines black

                DrawParabolicLine1();

            }

            if (i % 5 == 0)
            {
                RandomColorGenerator();

                Stroke(rColor, gColor, bColor); // make lines black

                DrawParabolicLine1();

            }

            if (i % 4 == 0)
            {
                RandomColorGenerator();

                Stroke(rColor, gColor, bColor); // make lines black

                DrawParabolicLine1();

            }

            if (i % 3 == 0)
            {
                RandomColorGenerator();

                Stroke(rColor, gColor, bColor); // make lines black

                DrawParabolicLine1();

            }

            if (i % 2 == 0)
            {
                RandomColorGenerator();

                Stroke(rColor, gColor, bColor); // make lines black

                DrawParabolicLine1();

            }

            if (i % 1 == 0)
            {
                RandomColorGenerator();

                Stroke(rColor, gColor, bColor); // make lines black

                DrawParabolicLine1();

            }

        }

        void RandomColorGenerator()
        {
            rColor = Random.Range(0, 255);
            gColor = Random.Range(0, 255);
            bColor = Random.Range(0, 255);
        }

        void DrawParabolicLine1()
        {
            Line(parabolicCurve1Axis1Start.x, parabolicCurve1Axis1Start.y, parabolicCurve1Axis2End.x, parabolicCurve1Axis2End.y); // where xStartPoint = 0, ,yStartPoint = 11, xEndPoint = 0, yEndPoint = 0

            parabolicCurve1Axis1Start.y = parabolicCurve1Axis1Start.y - 1; // y axis start point = axis1.y
            parabolicCurve1Axis2End.x = parabolicCurve1Axis2End.x + 1; // x axis end point = axis2.x
        }
    }

    void ParabolicCurve2()
    {
        for (int i = 0; i < parbolicCurve2NumberOfLines; i++)
        {
            if (i % 11 == 0)
            {
                RandomColorGenerator();

                Stroke(rColor, gColor, bColor); // make lines black

                DrawParabolicLine2();

            }

            if (i % 10 == 0)
            {
                RandomColorGenerator();

                Stroke(rColor, gColor, bColor); // make lines black

                DrawParabolicLine2();

            }

            if (i % 9 == 0)
            {
                RandomColorGenerator();

                Stroke(rColor, gColor, bColor); // make lines black

                DrawParabolicLine2();

            }

            if (i % 8 == 0)
            {
                RandomColorGenerator();

                Stroke(rColor, gColor, bColor); // make lines black

                DrawParabolicLine2();

            }

            if (i % 7 == 0)
            {
                RandomColorGenerator();

                Stroke(rColor, gColor, bColor); // make lines black

                DrawParabolicLine2();

            }

            if (i % 6 == 0)
            {
                RandomColorGenerator();

                Stroke(rColor, gColor, bColor); // make lines black

                DrawParabolicLine2();

            }

            if (i % 5 == 0)
            {
                RandomColorGenerator();

                Stroke(rColor, gColor, bColor); // make lines black

                DrawParabolicLine2();

            }

            if (i % 4 == 0)
            {
                RandomColorGenerator();

                Stroke(rColor, gColor, bColor); // make lines black

                DrawParabolicLine2();

            }

            if (i % 3 == 0)
            {
                RandomColorGenerator();

                Stroke(rColor, gColor, bColor); // make lines black

                DrawParabolicLine2();

            }

            if (i % 2 == 0)
            {
                RandomColorGenerator();

                Stroke(rColor, gColor, bColor); // make lines black

                DrawParabolicLine2();

            }

            if (i % 1 == 0)
            {
                RandomColorGenerator();

                Stroke(rColor, gColor, bColor); // make lines black

                DrawParabolicLine2();

            }

        }

        void RandomColorGenerator()
        {
            rColor = Random.Range(0, 255);
            gColor = Random.Range(0, 255);
            bColor = Random.Range(0, 255);
        }

        void DrawParabolicLine2()
        {
            Line(parabolicCurve2Axis1Start.x, parabolicCurve2Axis1Start.y, parabolicCurve2Axis2End.x, parabolicCurve2Axis2End.y); // where xStartPoint = 0, ,yStartPoint = 11, xEndPoint = 0, yEndPoint = 0

            parabolicCurve2Axis1Start.y = parabolicCurve2Axis1Start.y - 1; // y axis start point = axis1.y
            parabolicCurve2Axis2End.x = parabolicCurve2Axis2End.x - 1; // x axis end point = axis2.x
        }
    }

    void ParabolicCurve3()
    {
        for (int i = 0; i < parbolicCurve3NumberOfLines; i++)
        {
            if (i % 11 == 0)
            {
                RandomColorGenerator();

                Stroke(rColor, gColor, bColor); // make lines black

                DrawParabolicLine3();

            }

            if (i % 10 == 0)
            {
                RandomColorGenerator();

                Stroke(rColor, gColor, bColor); // make lines black

                DrawParabolicLine3();

            }

            if (i % 9 == 0)
            {
                RandomColorGenerator();

                Stroke(rColor, gColor, bColor); // make lines black

                DrawParabolicLine3();

            }

            if (i % 8 == 0)
            {
                RandomColorGenerator();

                Stroke(rColor, gColor, bColor); // make lines black

                DrawParabolicLine3();

            }

            if (i % 7 == 0)
            {
                RandomColorGenerator();

                Stroke(rColor, gColor, bColor); // make lines black

                DrawParabolicLine3();

            }

            if (i % 6 == 0)
            {
                RandomColorGenerator();

                Stroke(rColor, gColor, bColor); // make lines black

                DrawParabolicLine3();

            }

            if (i % 5 == 0)
            {
                RandomColorGenerator();

                Stroke(rColor, gColor, bColor); // make lines black

                DrawParabolicLine3();

            }

            if (i % 4 == 0)
            {
                RandomColorGenerator();

                Stroke(rColor, gColor, bColor); // make lines black

                DrawParabolicLine3();

            }

            if (i % 3 == 0)
            {
                RandomColorGenerator();

                Stroke(rColor, gColor, bColor); // make lines black

                DrawParabolicLine3();

            }

            if (i % 2 == 0)
            {
                RandomColorGenerator();

                Stroke(rColor, gColor, bColor); // make lines black

                DrawParabolicLine3();

            }

            if (i % 1 == 0)
            {
                RandomColorGenerator();

                Stroke(rColor, gColor, bColor); // make lines black

                DrawParabolicLine3();

            }

        }

        void RandomColorGenerator()
        {
            rColor = Random.Range(0, 255);
            gColor = Random.Range(0, 255);
            bColor = Random.Range(0, 255);
        }

        void DrawParabolicLine3()
        {
            Line(parabolicCurve3Axis1Start.x, parabolicCurve3Axis1Start.y, parabolicCurve3Axis2End.x, parabolicCurve3Axis2End.y); // where xStartPoint = 0, ,yStartPoint = 11, xEndPoint = 0, yEndPoint = 0

            parabolicCurve3Axis1Start.y = parabolicCurve3Axis1Start.y + 1; // y axis start point = axis1.y
            parabolicCurve3Axis2End.x = parabolicCurve3Axis2End.x + 1; // x axis end point = axis2.x
            // parabolicCurve3Axis2End.y = parabolicCurve3Axis2End.y + 1;
        }
    }

}
