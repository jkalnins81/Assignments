using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lecture4AssignmentPlusExtra : ProcessingLite.GP21
{
    // answer to reading exercise: The code is useful as it when it is called it reverses the direction of the vector - ie. like when colliding with objects, screen edges etc... the last line in the function is explained as follows; vector *= -1 is equal to vector = vector * -1.

    public Color background;
    
    float circleDiameter;
    float velocity = 0.01f;
    float acceleration = 0.01f;
    float gravity = 2;
    float bounce = 2;

    public bool gravityOn = false;
    public bool bounceOn = false;
    

    Vector2 normalizeInput;
    public Vector2 circlePosition;

    
    void Start()
    {
        Background(background);
        Stroke(0);
        circlePosition.x = Width / 2;
        circlePosition.y = Height / 2;
        circleDiameter = 2;
        Circle(circlePosition.x, circlePosition.y, circleDiameter);
        
    }

    void Bounce()
    {
        gravityOn = false;
        bounceOn = true;
        
    }
       

    void Update()
    {
        normalizeInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized;

        velocity = velocity + acceleration * Time.deltaTime;
        velocity = Mathf.Clamp(velocity, 0.005f, 0.01f);

        circlePosition = circlePosition + new Vector2(normalizeInput.x, normalizeInput.y) * velocity;

        if (Input.GetKeyDown(KeyCode.G) && bounceOn == false)
        {
            gravityOn = !gravityOn;
            

        }

        


        if (gravityOn == true && circlePosition.y != 0)
        {
            gravity = gravity + acceleration * Time.deltaTime;
            circlePosition = circlePosition + new Vector2(0, -0.01f) * gravity;

        }

        if(gravityOn == true && circlePosition.y == 0)
        {
            Bounce();
             
        }

        if (bounceOn == true)
        {
            bounce = bounce + acceleration * Time.deltaTime;
            circlePosition = circlePosition + new Vector2(0, 0.01f) * bounce;

            if (Input.GetKeyDown(KeyCode.G))
            {
                bounceOn = false;
                
            }

            if (circlePosition.y > 5)
            {
                bounceOn = false;
                gravityOn = true;
            }
        }

        


        if (circlePosition.y > Height)
        {
            circlePosition.y = Height;
            Background(background);
            Circle(circlePosition.x, circlePosition.y, circleDiameter);
        }

        if(circlePosition.y < 0)
        {
            circlePosition.y = 0;
            Background(background);
            Circle(circlePosition.x, circlePosition.y, circleDiameter);
        }

        if(circlePosition.y > 0 && circlePosition.y < Height)
        {
            Background(background);
            Circle(circlePosition.x, circlePosition.y, circleDiameter);
        }

        
        if (circlePosition.x > 0 && circlePosition.x < Width)
        {
            Background(background);
            Circle(circlePosition.x, circlePosition.y, circleDiameter);
        }

        if (circlePosition.x > Width && circlePosition.x < Width + 1)
        {
            Background(background);
            Circle(Width, circlePosition.y, circleDiameter);
            Circle(0, circlePosition.y, circleDiameter);
        }

        if (circlePosition.x > Width + 1)
        {
            Background(background);
            circlePosition.x = 0;
            Circle(circlePosition.x, circlePosition.y, circleDiameter);
            
        }

        if (circlePosition.x < 0 && circlePosition.x > 0 - 1)
        {
            Background(background);
            Circle(Width, circlePosition.y, circleDiameter);
            Circle(0, circlePosition.y, circleDiameter);
        }

        if (circlePosition.x < 0 - 1)
        {
            Background(background);
            circlePosition.x = Width;
            Circle(circlePosition.x, circlePosition.y, circleDiameter);

        }

        

        

    }
}
