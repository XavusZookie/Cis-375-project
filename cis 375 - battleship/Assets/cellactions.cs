using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cellactions : MonoBehaviour
{
    public GameObject hit;
    public GameObject miss;




    public void OnMouseUpAsButton()
    {
        if (GameManager.enemyturn == true || GameManager.whowon != 0)
            return;

        foreach (Vector3 coord in GameManager.allyshipcoords)
        {
            if (coord == this.transform.position)
            {
                GameManager.enemyships[GameManager.allycounter] = true;
                GameManager.allycounter++;
                Debug.Log("clicked our ship");
                Instantiate(hit, this.transform.position, Quaternion.identity);
        GameManager.enemyturn = true;
                checkwinner();

                Destroy(this.gameObject);
                return;
            }
        }
        checkwinner();

        Instantiate(miss, this.transform.position, Quaternion.identity);


        GameManager.enemyturn = true;

        Destroy(this.gameObject);
    }


    public void checkwinner()
    {
        foreach (bool dead in GameManager.allyships)
        {
            if (dead == false)
            {

                return;
            }

        }

        GameManager.whowon = 1;
    }
}
