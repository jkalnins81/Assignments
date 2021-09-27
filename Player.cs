using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : ProcessingLite.GP21
{
    

    public Color background;

    public float circleDiameter;

    Vector2 velocity;

    float speed = 5f;

    Vector2 acceleration;

    Vector2 gravity;

    Vector2 bounce;

    public bool gravityOnCircle = false;
    public bool bounceOnCircle = false;
    
    Vector2 normalizeInput;

    public Vector2 circlePosition;

    Player player;

    public Vector2 playerPosition;

    Vector2 playerVelocity;

    public Player(float x, float y)
    {
        playerPosition = new Vector2(x, y);
        playerPosition.x = x;
        playerPosition.y = y;
        
    }

    void Start()
    {
        Background(background);
    }

    public void DrawPlayer()
    {
        Stroke(0);
        circleDiameter = 2;
        Circle(playerPosition.x, playerPosition.y, circleDiameter);
    }



    void BounceCircle()
    {
        gravityOnCircle = false;
        bounceOnCircle = true;

    }


    public void UpdatePlayerPos()
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

        playerPosition = playerPosition + new Vector2(normalizeInput.x, normalizeInput.y) + velocity;

        // circlePosition = circlePosition + new Vector2(normalizeInput.x, normalizeInput.y) + velocity;

        if (Input.GetKeyDown(KeyCode.G) && bounceOnCircle == false)
        {
            gravityOnCircle = !gravityOnCircle;

        }


        if (gravityOnCircle == true && playerPosition.y != 0)
        {
            gravity = gravity + new Vector2(0, -0.1f) * Time.deltaTime;
            playerPosition = playerPosition + gravity;


        }


        if (gravityOnCircle == true && playerPosition.y <= 0)
        {
            BounceCircle();

        }

        if (bounceOnCircle == true)
        {
            bounce = bounce + new Vector2(0, 0.1f) * Time.deltaTime;
            playerPosition = playerPosition + bounce;


            if (Input.GetKeyDown(KeyCode.G))
            {
                bounceOnCircle = false;

            }

            if (playerPosition.y > 5)
            {
                bounceOnCircle = false;
                gravityOnCircle = true;
            }
        }

        



            //Background(background);

        if (playerPosition.y > Height)
        {
            playerPosition.y = Height;
            Fill(0);
            Circle(playerPosition.x, playerPosition.y, circleDiameter);
            
        }

        if (playerPosition.y < 0)
        {
            playerPosition.y = 0;
            Background(background);
            Fill(0);
            Circle(playerPosition.x, playerPosition.y, circleDiameter);
            
        }

        if (playerPosition.y > 0 && playerPosition.y < Height)
        {
            // Background(background);

            Fill(0);
            //Circle(circlePosition.x, circlePosition.y, circleDiameter);
            Circle(playerPosition.x, playerPosition.y, circleDiameter);


        }

        if (playerPosition.x > 0 && playerPosition.x < Width)
        {
            Fill(0);
            // Background(background);
            Circle(playerPosition.x, playerPosition.y, circleDiameter);
            
        }


        if (playerPosition.x > Width && playerPosition.x < Width + 1)
        {
            // Background(background);
            Fill(0);
            Circle(Width, playerPosition.y, circleDiameter);
            Circle(0, playerPosition.y, circleDiameter);
            
        }

        
        if (playerPosition.x > Width + 1)
        {
            // Background(background);
            Fill(0);
            playerPosition.x = 0;
            Circle(playerPosition.x, playerPosition.y, circleDiameter);
            

        }

        
        if (playerPosition.x < 0 && playerPosition.x > 0 - 1)
        {
            // Background(background);
            Fill(0);
            Circle(Width, playerPosition.y, circleDiameter);
            Circle(0, playerPosition.y, circleDiameter);
            
        }

        
        if (playerPosition.x < 0 - 1)
        {
            // Background(background);
            Fill(0);
            playerPosition.x = Width;
            Circle(playerPosition.x, playerPosition.y, circleDiameter);
            

        }

        




    }
}
