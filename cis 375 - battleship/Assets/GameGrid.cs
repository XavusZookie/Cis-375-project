using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameGrid : MonoBehaviour
{
    
    public int height = 10, width = 10;
    public float Gridspacesize = 5f;

    private GameObject[,] gameGrid;
    public GameObject gridcellprefab;

    void Start()
    {
        creategrid();
    }

    public void creategrid()
    {
        gameGrid = new GameObject[height, width];
        if(gridcellprefab == null)
        {
            return;
        }

        for(int y = 0; y < height; y++)
        {
            for(int x = 0; x < width; x++)
            {
                gameGrid[x,y] = Instantiate(gridcellprefab, new Vector3(x * Gridspacesize + this.transform.position.x, y * Gridspacesize + this.transform.position.y), Quaternion.identity);
                gameGrid[x,y].transform.parent = transform;
                
            }
        }
    }
    
}
