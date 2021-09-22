using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lecture4AssignmentPlusExtra : ProcessingLite.GP21
{
    // answer to reading exercise: The code is useful as it when it is called it reverses the direction of the vector - ie. like when colliding with objects, screen edges etc... the last line in the function is explained as follows; vector *= -1 is equal to vector = vector * -1.

    public Color background;
    
    float circleDiameter;
    float circle2Diameter;

    Vector2 velocity;
    
    float speed = 5f;

    Vector2 acceleration;

    Vector2 gravity;

    Vector2 bounce;

    public bool gravityOnCircle = false;
    public bool bounceOnCircle = false;

    public bool gravityOnCircle2 = false;
    public bool bounceOnCircle2 = false;


    Vector2 normalizeInput;

    public Vector2 circlePosition;
    public Vector2 circle2Position;

    
    void Start()
    {
        Background(background);
        Stroke(0);

        circlePosition.x = Width / 2;
        circlePosition.y = Height / 2;

        circle2Position.x = Width / 2;
        circle2Position.y = Height / 2 - 5;

        circleDiameter = 2;
        circle2Diameter = 2;

        Circle(circlePosition.x, circlePosition.y, circleDiameter);

        Circle(circle2Position.x, circle2Position.y, circle2Diameter);


    }

    void BounceCircle()
    {
        gravityOnCircle = false;
        bounceOnCircle = true;
        
    }

    void BounceCircle2()
    {
        gravityOnCircle2 = false;
        bounceOnCircle2 = true;
    }
       

    void Update()
    {
        normalizeInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized * speed * Time.deltaTime;

        acceleration = new Vector2(normalizeInput.x, normalizeInput.y);

        velocity = velocity + acceleration * Time.deltaTime;

        // velocity = Mathf.Clamp(velocity, 0.005f, 0.01f);

        gravity = new Vector2(0, -0.01f);

        bounce = new Vector2(0, 0.01f);

        if (velocity.magnitude > 0.01f) // to limit circle a maximum speed
        {
            velocity = velocity.normalized * 0.01f;
        }

        else if (acceleration == Vector2.zero) // to enable circle to deccelerate
        {
            velocity = velocity * 0.99f;
        }

        circlePosition = circlePosition + new Vector2(normalizeInput.x, normalizeInput.y) + velocity;

        circle2Position = circle2Position + new Vector2(normalizeInput.x, normalizeInput.y);

        if (Input.GetKeyDown(KeyCode.G) && bounceOnCircle == false)
        {
            gravityOnCircle = !gravityOnCircle;
            
        }

        if (Input.GetKeyDown(KeyCode.G) && bounceOnCircle2 == false)
        {
            gravityOnCircle2 = !gravityOnCircle2;

        }


        if (gravityOnCircle == true && circlePosition.y != 0)
        {
            gravity = gravity + new Vector2(0,-0.1f) * Time.deltaTime;
            circlePosition = circlePosition + gravity;
            

        }

        if (gravityOnCircle2 == true && circle2Position.y != 0)
        {
            gravity = gravity + new Vector2(0, -0.1f) * Time.deltaTime;
            circle2Position = circle2Position + gravity;

        }


        if (gravityOnCircle == true && circlePosition.y <= 0)
        {
            BounceCircle();
             
        }

        if (gravityOnCircle2 == true && circle2Position.y == 0)
        {
            BounceCircle2();

        }

        if (bounceOnCircle == true)
        {
            bounce = bounce + new Vector2(0,0.1f) * Time.deltaTime;
            circlePosition = circlePosition + bounce;
            

            if (Input.GetKeyDown(KeyCode.G))
            {
                bounceOnCircle = false;
                
            }

            if (circlePosition.y > 5)
            {
                bounceOnCircle = false;
                gravityOnCircle = true;
            }
        }

        if (bounceOnCircle2 == true)
        {
            bounce = bounce + new Vector2(0, 0.1f) * Time.deltaTime;
            circle2Position = circle2Position + bounce;

            if (Input.GetKeyDown(KeyCode.G))
            {
                bounceOnCircle2 = false;

            }

            if (circle2Position.y > 5)
            {
                bounceOnCircle2 = false;
                gravityOnCircle2 = true;
            }
        }




        if (circlePosition.y > Height)
        {
            circlePosition.y = Height;
            Background(background);
            Circle(circlePosition.x, circlePosition.y, circleDiameter);
            Circle(circle2Position.x, circle2Position.y, circle2Diameter);
        }

        if (circle2Position.y > Height)
        {
            circle2Position.y = Height;
            Background(background);
            Circle(circle2Position.x, circle2Position.y, circle2Diameter);
            Circle(circlePosition.x, circlePosition.y, circleDiameter);
        }

        if (circlePosition.y < 0)
        {
            circlePosition.y = 0;
            Background(background);
            Circle(circlePosition.x, circlePosition.y, circleDiameter);
            Circle(circle2Position.x, circle2Position.y, circle2Diameter);
        }

        if (circle2Position.y < 0)
        {
            circle2Position.y = 0;
            Background(background);
            Circle(circle2Position.x, circle2Position.y, circle2Diameter);
            Circle(circlePosition.x, circlePosition.y, circleDiameter);
        }

        if (circlePosition.y > 0 && circlePosition.y < Height)
        {
            Background(background);
            Circle(circlePosition.x, circlePosition.y, circleDiameter);
            Circle(circle2Position.x, circle2Position.y, circle2Diameter);

        }

        if (circle2Position.y > 0 && circle2Position.y < Height)
        {
            Background(background);
            Circle(circlePosition.x, circlePosition.y, circleDiameter);
            Circle(circle2Position.x, circle2Position.y, circle2Diameter);

        }


        if (circlePosition.x > 0 && circlePosition.x < Width)
        {
            Background(background);
            Circle(circlePosition.x, circlePosition.y, circleDiameter);
            Circle(circle2Position.x, circle2Position.y, circle2Diameter);

        }

        
        if (circlePosition.x > Width && circlePosition.x < Width + 1)
        {
            Background(background);
            Circle(Width, circlePosition.y, circleDiameter);
            Circle(0, circlePosition.y, circleDiameter);
            Circle(circle2Position.x, circle2Position.y, circle2Diameter);
        }

        if (circle2Position.x > Width && circle2Position.x < Width + 1)
        {
            Background(background);
            Circle(Width, circle2Position.y, circle2Diameter);
            Circle(0, circle2Position.y, circle2Diameter);
            Circle(circlePosition.x, circlePosition.y, circleDiameter);
        }

        if (circlePosition.x > Width + 1)
        {
            Background(background);
            circlePosition.x = 0;
            Circle(circlePosition.x, circlePosition.y, circleDiameter);
            Circle(circle2Position.x, circle2Position.y, circle2Diameter);
            
        }

        if (circle2Position.x > Width + 1)
        {
            Background(background);
            circle2Position.x = 0;
            Circle(circle2Position.x, circle2Position.y, circle2Diameter);
            Circle(circlePosition.x, circlePosition.y, circleDiameter);

        }

        if (circlePosition.x < 0 && circlePosition.x > 0 - 1)
        {
            Background(background);
            Circle(Width, circlePosition.y, circleDiameter);
            Circle(0, circlePosition.y, circleDiameter);
            Circle(circle2Position.x, circle2Position.y, circle2Diameter);
        }

        if (circle2Position.x < 0 && circle2Position.x > 0 - 1)
        {
            Background(background);
            Circle(Width, circle2Position.y, circle2Diameter);
            Circle(0, circle2Position.y, circle2Diameter);
            Circle(circlePosition.x, circlePosition.y, circleDiameter);
        }

        if (circlePosition.x < 0 - 1)
        {
            Background(background);
            circlePosition.x = Width;
            Circle(circlePosition.x, circlePosition.y, circleDiameter);
            Circle(circle2Position.x, circle2Position.y, circle2Diameter);

        }

        if (circle2Position.x < 0 - 1)
        {
            Background(background);
            circle2Position.x = Width;
            Circle(circle2Position.x, circle2Position.y, circle2Diameter);
            Circle(circlePosition.x, circlePosition.y, circleDiameter);

        }




    }
}
