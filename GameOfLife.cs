using UnityEngine;

public class GameOfLife : ProcessingLite.GP21
{
    GameCell[,] cells; //Our game grid matrix
    float cellSize = 0.25f; //Size of our cells (was 0.25f)
    int numberOfColums;
    int numberOfRows;
    [SerializeField] int spawnChancePercentage = 20; // was 20

    //int arrayLength = cells[];

    public Camera cam;
    float minCameraSize = 1f;
    float maxCameraSize = 5f;
    float mouseScrollSensitivity = 1f;
    float mouseCursorSensitivity = 2f;
    float zoomOutSensitivity = 5f;

    void Start()
    {
        
        //Lower framerate makes it easier to test and see whats happening.
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 1;

        //Calculate our grid depending on size and cellSize
        numberOfColums = (int)Mathf.Floor(Width / cellSize);
        numberOfRows = (int)Mathf.Floor(Height / cellSize);

        //Debug.Log("numberOfColums" + numberOfColums); // = 76
        //Debug.Log("numberOfRows" + numberOfRows); // = 40

        //Initiate our matrix array
        cells = new GameCell[numberOfColums, numberOfRows];

        //Create all objects

        //For each row
        for (int y = 0; y < numberOfRows; y++)
        {
            //for each column in each row
            for (int x = 0; x < numberOfColums; x++)
            {
                //Create our game cell objects, multiply by cellSize for correct world placement
                cells[x, y] = new GameCell(x * cellSize, y * cellSize, cellSize);

                

                //Random check to see if it should be alive
                if (Random.Range(0, 100) < spawnChancePercentage)
                {
                    cells[x, y].alive = true;
                    Debug.Log(cells.GetLength(0));
                }
            }
        }
    }

    void Update()
    {
        float cameraSize = Camera.main.orthographicSize;

        cameraSize += Input.GetAxis("Mouse ScrollWheel") * mouseScrollSensitivity * -1;
        cameraSize = Mathf.Clamp(cameraSize, minCameraSize, maxCameraSize);
        Camera.main.orthographicSize = cameraSize;

        if (Input.GetAxis("Mouse ScrollWheel") > 0) // zoom in
        {
            Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, new Vector3(MouseX, MouseY, Camera.main.transform.position.z), mouseCursorSensitivity * Time.deltaTime);
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0) // zoom out
        {
            Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, new Vector3(9.569f, 5, -10), zoomOutSensitivity * Time.deltaTime);
        }



        if (Input.GetKey(KeyCode.W))
        {
            Application.targetFrameRate += 1; // increase frame rate
        }

        if (Input.GetKey(KeyCode.S))
        {
            Application.targetFrameRate -= 1; // decrease frame rate
        }


        //Clear screen

        Background(0);





        //TODO: Calculate next generation

        for (int y = 0; y < numberOfRows; y++)
        {
            for (int x = 0; x < numberOfColums; x++)
            {

                float numberOfAdjacentCellsAlive = 0;

                //Check adjacent cells to the current cell (8 positions)
                if (x - 1 >= 0 && y < numberOfRows && cells[x - 1, y].alive) // left
                {
                    numberOfAdjacentCellsAlive += 1;
                }

                if (x - 1 >= 0 && y + 1 < numberOfRows && cells[x - 1, y + 1].alive) // diagonal left upwards
                {
                    numberOfAdjacentCellsAlive += 1;
                }

                if (x < numberOfColums && y + 1 < numberOfRows && cells[x, y + 1].alive) // up
                {
                    numberOfAdjacentCellsAlive += 1;
                }

                if (x + 1 < numberOfColums && y + 1 < numberOfRows && cells[x + 1, y + 1].alive) // diagonal right upwards
                {
                    numberOfAdjacentCellsAlive += 1;
                }

                if (x + 1 < numberOfColums && y < numberOfRows && cells[x + 1, y].alive) // right
                {
                    numberOfAdjacentCellsAlive += 1;
                }

                if (x + 1 < numberOfColums && y - 1 >= 0 && cells[x + 1, y - 1].alive) // diagonal right downwards
                {
                    numberOfAdjacentCellsAlive += 1;
                }

                if (x < numberOfColums && y - 1 >= 0 && cells[x, y - 1].alive) // down
                {
                    numberOfAdjacentCellsAlive += 1;
                }

                if (x - 1 >= 0 && y - 1 >= 0 && cells[x - 1, y - 1].alive) // diagonal left downwards
                {
                    numberOfAdjacentCellsAlive += 1;
                }

                // Rules of the game

                if (cells[x, y] == false && numberOfAdjacentCellsAlive == 3)
                {
                    cells[x, y].aliveNextGen = true;
                }

                if (cells[x, y].alive && numberOfAdjacentCellsAlive == 2 || cells[x, y].alive && numberOfAdjacentCellsAlive == 3)
                {
                    cells[x, y].aliveNextGen = true;
                }

                if (numberOfAdjacentCellsAlive < 2 || numberOfAdjacentCellsAlive > 3)
                {
                    cells[x, y].aliveNextGen = false;
                }

                // Simulation Stable

                if (cells[x, y].alive && numberOfAdjacentCellsAlive == 2 || numberOfAdjacentCellsAlive == 3)
                {
                    cells[x, y].simulationStable = true;


                }

                else cells[x, y].simulationStable = false;

            }


        }




        //TODO: update buffer (can be done with a (1) bool or, (2))

        for (int y = 0; y < numberOfRows; y++)
        {
            for (int x = 0; x < numberOfColums; x++)
            {
                cells[x, y].alive = cells[x, y].aliveNextGen;
                //Draw current cell

            }


        }

        //Draw all cells.
        for (int y = 0; y < numberOfRows; y++)
        {
            for (int x = 0; x < numberOfColums; x++)
            {
                cells[x, y].Draw();
                //Draw current cell




            }


        }

        //for (int y = 0; y <= cells.GetLength(0);)
        //{
        //    for (int x = 0; x < cells.GetLength(1);)
        //    {

        //        if (cells[x, y].aliveNextGen)
        //        {
        //            Debug.Log("simulation is stable");
        //        }

        //    }
        //}

        






    }
}

//You will probebly need to keep track of more things in this class
public class GameCell : ProcessingLite.GP21
{
    float x, y; //Keep track of our position
    float size; //our size

    //Keep track if we are alive
    public bool alive = false;
    public bool aliveNextGen = false;
    public int numberOfGensAlive = 0;

    public bool simulationStable = false;

    //Constructor
    public GameCell(float x, float y, float size)
    {
        //Our X is equal to incoming X, and so forth
        //adjust our draw position so we are centered
        this.x = x + size / 2;
        this.y = y + size / 2;

        //diameter/radius draw size fix
        this.size = size / 2;

        
    }

    public void Draw()
    {
        //If we are alive, draw our dot.
        if (alive)
        {
            //draw our dots
            numberOfGensAlive++;
            // Debug.Log("numberOfGensAlive" + numberOfGensAlive);

            Stroke(Mathf.Clamp(numberOfGensAlive * 5, 0, 255), 36, 248);
            Circle(x, y, size);
            // Debug.Log(" X = " + x + " Y = " + y);
            
        }

       
    }
}
