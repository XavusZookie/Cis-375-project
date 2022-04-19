using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameManager
{
    public static bool enemyturn = false;
    public static int whowon = 0;
    public static int allycounter= 0;
    public static bool[] allyships = { false, false, false, false, false, false, false, false, false, false, false, false, false, false };
    public static Vector3[] allyshipcoords ={new Vector3(-17,3), new Vector3(-17f, .5f)
    , new Vector3(-22, 20.5f), new Vector3(-24.5f, 20.5f), new Vector3(-27, 20.5f)
    , new Vector3(-27f, 3f), new Vector3(-27f, 5.5f), new Vector3(-27f, 8), new Vector3(-27f, 10.5f)
    , new Vector3(-7, 13f), new Vector3(-9.5f, 13f), new Vector3(-12, 13f), new Vector3(-14.5f,13f), new Vector3(-17, 13f)};

    public static int enemycounter = 0;

    public static bool[] enemyships = { false, false, false, false, false, false, false, false, false, false, false, false, false, false };
    public static Vector3[] enemyshipscoords = {new Vector3(3,3), new Vector3(5.5f, 3)
    , new Vector3(8, 10.5f), new Vector3(10.5f, 10.5f), new Vector3(13, 10.5f)
    , new Vector3(15.5f, 0.5f), new Vector3(18, 0.5f), new Vector3(20.5f, 0.5f), new Vector3(23, 0.5f)
    , new Vector3(18, 8f), new Vector3(18, 10.5f), new Vector3(18, 13f), new Vector3(18,15.5f), new Vector3(18, 18f)};




}
