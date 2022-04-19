using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycellactions : MonoBehaviour
{
    public GameObject hit;
    public GameObject miss;

    public void OnMouseUpAsButton()
    {
        if (GameManager.enemyturn == false || GameManager.whowon != 0)
            return;

        foreach (Vector3 coord in GameManager.enemyshipscoords)
        {
            if (coord == this.transform.position)
            {
                GameManager.enemyships[GameManager.enemycounter] = true;
                GameManager.enemycounter++;
                Debug.Log("clicked thier ship");
                Instantiate(hit, this.transform.position, Quaternion.identity);
                GameManager.enemyturn = false;
                checkwinner();

                Destroy(this.gameObject);
                return;
            }
        }

        checkwinner();

        


        Instantiate(miss, this.transform.position, Quaternion.identity);
        GameManager.enemyturn = false;

        Destroy(this.gameObject);
    }

    public void checkwinner()
    {
foreach (bool dead in GameManager.enemyships)
        {
            if (dead ==false)
            {
                
                return;
            }
            
        }

        GameManager.whowon = 2;
    }


}

