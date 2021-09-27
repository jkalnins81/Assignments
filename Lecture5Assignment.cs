using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lecture5Assignment : ProcessingLite.GP21
{
    int numberOfBalls = 10; //start ammount
    int ballLimit = 100;
    Ball[] balls;

    int currentNumberOfBalls;
    Player player;

    bool gameHasEnded = false;

    public GameObject gameOverScreen;

    private void Start()
    {
        gameOverScreen.SetActive(false);

        balls = new Ball[ballLimit];

        currentNumberOfBalls = numberOfBalls;

        player = new Player(Width / 2, Height / 2);

        CreateBalls();

        
        InvokeRepeating("SpawnNewBall", 3, 3);

    }

    private bool CircleCollision(float x1, float y1, float size1, float x2, float y2, float size2)
    {

        float maxDistance = size1/2 + size2/2;

        //first a quick check to see if we are too far away in x or y direction
        //if we are far away we don't collide so just return false and be done.
        if (Mathf.Abs(x1 - x2) > maxDistance || Mathf.Abs(y1 - y2) > maxDistance)
        {

            return false;

        }
        //we then run the slower distance calculation
        //Distance uses Pythagoras to get exact distance, if we still are to far away we are not colliding.
        else if (Vector2.Distance(new Vector2(x1, y1), new Vector2(x2, y2)) > maxDistance)
        {
            
            return false;
        }
        //We now know the points are closer then the distance so we are colliding!
        else
        {
            
            return true;
        }
    }

    void CreateBalls()
    {
        for (int i = 0; i < ballLimit; i++)
        {
            if(player.playerPosition.x != 5 && player.playerPosition.y != 5) // so that new balls don't spawn on the player
            {
                balls[i] = new Ball(5, 5);
            }

            
        }
    }

    void SpawnNewBall()
    {
        currentNumberOfBalls++;
    }

    
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Time.timeScale = 0; // pauses game
            gameOverScreen.SetActive(true);
            // Restart();
        }
    }

    public void Restart()
    {
        gameOverScreen.SetActive(false);
        gameHasEnded = false;
        player.playerPosition.x = Width / 2;
        player.playerPosition.y = Height / 2;
        Time.timeScale = 1;
        currentNumberOfBalls = numberOfBalls; // where numberOfBalls = 10
        CreateBalls();

    }


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)) 
        {
            Restart();
        }

        balls[0].WhiteBackground();

        for (int i = 0; i < currentNumberOfBalls; i++)
        {
            balls[i].UpdatePos();
            balls[i].Draw();
        }

        

        player.UpdatePlayerPos();
        player.DrawPlayer();

        for (int i = 0; i < currentNumberOfBalls; i++)
        {

            bool hit = CircleCollision(balls[i].position.x, balls[i].position.y, balls[i].ballDiameter, player.playerPosition.x, player.playerPosition.y, player.circleDiameter);

            if (hit == true)
            {
                

                EndGame();

                
            }

        }
    }

    
        
}








