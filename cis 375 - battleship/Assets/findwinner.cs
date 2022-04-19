using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class findwinner : MonoBehaviour
{
    public Text display;
    // Update is called once per frame
    void Update()
    {

        if (GameManager.whowon == 0)
        {
            if (GameManager.enemyturn == false)
            {
                display.text = "Player 1 turn";
            }
            else
            {
                display.text = "Player 2 turn";

            }
        }
        else if(GameManager.whowon == 1)
        {
            display.text = "Player 1 Won!";

        }
        else if (GameManager.whowon == 2)
        {
            display.text = "Player 2 Won!";

        }
    }

    public void replay()
    {
        GameManager.enemyships = new bool[]{ false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        GameManager.allyships = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        GameManager.enemyturn = false;
        GameManager.whowon = 0;
        GameManager.allycounter = 0;
        GameManager.enemycounter = 0;





        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void leave()
    {
        Application.Quit();
    }
}
