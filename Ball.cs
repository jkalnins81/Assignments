using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : ProcessingLite.GP21
{
    
    
    //Our class variables
    public Vector2 position; //Ball position
    Vector2 velocity; //Ball direction

    public float ballDiameter = 2f;

    int randomColorR;
    int randomColorG;
    int randomColorB;
    Player player;

    

    //Ball Constructor, called when we type new Ball(x, y);
    public Ball(float x, float y)
    {
        //Set our position when we create the code.
        position = new Vector2(x, y);

        //Create the velocity vector and give it a random direction.
        velocity = new Vector2();
        velocity.x = Random.Range(0, 11) - 5;
        velocity.y = Random.Range(0, 11) - 5;
    }

    //Draw our ball
    public void Draw()
    {
        randomColorR = Random.Range(50, 255);
        randomColorG = Random.Range(50, 255);
        randomColorB = Random.Range(50, 255);

        Stroke(randomColorR, randomColorG, randomColorB);
        Fill(randomColorR, randomColorG, randomColorB); // changes circle color
        Circle(position.x, position.y, ballDiameter);
    }

    public void WhiteBackground()
    {
        Background(255);
    }


    //Update our ball
    public void UpdatePos()
    {
        position += velocity * Time.deltaTime;

        if (position.x > Width)
        {
            position.x = Width;
            velocity.x = velocity.x * -1;
        }

        if (position.x < 0)
        {
            position.x = 0;
            velocity.x = velocity.x * -1;
        }

        if (position.y > Height)
        {
            position.y = Height;
            velocity.y = velocity.y * -1;
        }

        if (position.y < 0)
        {
            position.y = 0;
            velocity.y = velocity.y * -1;
        }

        

    }

   

    
}
