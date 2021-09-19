using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UI;

public class AssignmentLecture3Extra : ProcessingLite.GP21
{
    public float randomVectorX;
    public float randomVectorY;

    public Vector2 randomVectorXY;

    public Color background;
    public float score = 0;
    float diff = 0.2f;

    public float mouseXposition;
    public float mouseYposition;

    // Start is called before the first frame update
    private void Awake()
    {
        
        

    }

    void Start()
    {
        randomVectorX = Random.Range(1, 5);
        randomVectorY = Random.Range(1, 5);

        randomVectorXY = new Vector2(randomVectorX, randomVectorY);

        Background(background);

        DrawGraph();      
        
        
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(Width / 2, Height / 2, 20, 20), "Vector");
    }


    // Update is called once per frame
    void DrawGraph()
    {
        Stroke(0); // makes line black
        StrokeWeight(0.5f);

        Line(0, 1, 41, 1);
        Line(0, 2, 41, 2);
        Line(0, 3, 41, 3);
        Line(0, 4, 41, 4);
        Line(0, 5, 41, 5);
        Line(0, 6, 41, 6);
        Line(0, 7, 41, 7);
        Line(0, 8, 41, 8);
        Line(0, 9, 41, 9);
        Line(0, 10, 41, 10);
        Line(0, 11, 41, 11);
        Line(0, 12, 41, 12);
        Line(0, 13, 41, 13);
        Line(0, 14, 41, 14);
        Line(0, 15, 41, 15);
        Line(0, 16, 41, 16);
        Line(0, 17, 41, 17);
        Line(0, 18, 41, 18);
        Line(0, 19, 41, 19);
        Line(0, 20, 41, 20);

        Line(1, 0, 1, 20);
        Line(2, 0, 2, 20);
        Line(3, 0, 3, 20);
        Line(4, 0, 4, 20);
        Line(5, 0, 5, 20);
        Line(6, 0, 6, 20);
        Line(7, 0, 7, 20);
        Line(8, 0, 8, 20);
        Line(9, 0, 9, 20);
        Line(10, 0, 10, 20);
        Line(11, 0, 11, 20);
        Line(12, 0, 12, 20);
        Line(13, 0, 13, 20);
        Line(14, 0, 14, 20);
        Line(15, 0, 15, 20);
        Line(16, 0, 16, 20);
        Line(17, 0, 17, 20);
        Line(18, 0, 18, 20);
        Line(19, 0, 19, 20);
        Line(20, 0, 20, 20);
        Line(21, 0, 21, 20);
        Line(22, 0, 22, 20);
        Line(23, 0, 23, 20);
        Line(24, 0, 24, 20);
        Line(25, 0, 25, 20);
        Line(26, 0, 26, 20);
        Line(27, 0, 27, 20);
        Line(28, 0, 28, 20);
        Line(29, 0, 29, 20);
        Line(30, 0, 30, 20);
        Line(31, 0, 31, 20);
        Line(32, 0, 32, 20);
        Line(33, 0, 33, 20);
        Line(34, 0, 34, 20);
        Line(35, 0, 35, 20);
        Line(36, 0, 36, 20);
        Line(37, 0, 37, 20);
        Line(38, 0, 38, 20);
        Line(39, 0, 39, 20);
        Line(40, 0, 40, 20);
        





    }

    void Update()
    {
        mouseXposition = MouseX;
        mouseYposition = MouseY;

        if (Input.GetMouseButtonDown(0))
        {
            Background(255);
            DrawGraph();
            Stroke(0);
            Circle(MouseX, MouseY, 1);

            if (MouseX > randomVectorX - diff && MouseX < randomVectorX + diff && MouseY > randomVectorY - diff && MouseY < randomVectorY + diff)
            {
                score = score + 1;

                randomVectorX = Random.Range(1, 5);
                randomVectorY = Random.Range(1, 5);
                randomVectorXY = new Vector2(randomVectorX, randomVectorY);
            }

            else
            {

                score = score - 1;

                randomVectorX = Random.Range(1, 5);
                randomVectorY = Random.Range(1, 5);
                randomVectorXY = new Vector2(randomVectorX, randomVectorY);
            }
        }
    }
}
