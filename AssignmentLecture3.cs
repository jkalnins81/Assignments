using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignmentLecture3 : ProcessingLite.GP21
{
    // The answer to 9. It can be useful as it calculates the length of a vector based on it's coordinates - for instance the distance between two game objects. This is explained further in Pythagoras's Theorem which as in the question is where c = the square root of (a squared + b squared).

    public float mouseXposition;
    public float mouseYposition;

    public float circleX;
    public float circleY;
    public float circleDiameter;

    public float circleSpeed;

    public Color background;

    public Vector2 directionOfCircleToMouse;
    public float distanceOfCircleToMouse;

    Vector2 circleVector;
    Vector2 mouseVector;

    // Start is called before the first frame update
    void Start()
    {
        Background(background);
        Stroke(0); // makes stroke black
        Circle(circleX, circleY, circleDiameter);

        

    }

    
    IEnumerator MoveCircle()
    {
        

        while (Input.GetMouseButtonDown(0)) // true every frame the button is pressed
        {
            directionOfCircleToMouse = new Vector2(MouseX - circleX, MouseY - circleY).normalized;

            circleVector = new Vector2(circleX, circleY);
            mouseVector = new Vector2(MouseX, MouseY);

            distanceOfCircleToMouse = Vector2.Distance(circleVector, mouseVector);



            if (distanceOfCircleToMouse < 20)
            {
                circleSpeed = 0.01f;
            }

            if (distanceOfCircleToMouse > 20)
            {
                circleSpeed = circleSpeed * 0.05f;
            }

           

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

                yield return new WaitForSeconds(circleSpeed);

                DrawCircle();

        }

        

        yield return null;
    }



    void DrawCircle()
    {

        if (circleX > 0 || circleX < 40.6f || circleY > 0 || circleY < 20 || distanceOfCircleToMouse > 0.5f)
        {
        
            Background(background);
            Stroke(0);

            circleX = circleX + (directionOfCircleToMouse.x * 0.1f);
            circleY = circleY + (directionOfCircleToMouse.y * 0.1f);

            Circle(circleX, circleY, circleDiameter);

        }

        if (circleX < 0 || circleX > 40.6f || circleY < 0 || circleY > 20)
        {
            StopCoroutine(MoveCircle());
            StartCoroutine(BounceCircle());


        }
    }

        IEnumerator BounceCircle()
        {
            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return new WaitForSeconds(circleSpeed);

            Bounce();

            yield return null;
        }





    

    void Bounce()
    {
        Background(background);
        Stroke(0);

        circleX = circleX - (directionOfCircleToMouse.x * 0.1f);
        circleY = circleY - (directionOfCircleToMouse.y * 0.1f);

        Circle(circleX, circleY, circleDiameter);
    }

    void Update()
    {
        mouseXposition = MouseX;
        mouseYposition = MouseY;

        if (Input.GetMouseButton(0)) // when the mouse button is being pressed down
        {
            Line(circleX, circleY, MouseX, MouseY);
        }

        if (circleX > 0 || circleX < 40.6f || circleY > 0 || circleY < 20)
        {
            StartCoroutine(MoveCircle());
        }


        Debug.Log(distanceOfCircleToMouse);
        Debug.Log(mouseVector);


    }

}
