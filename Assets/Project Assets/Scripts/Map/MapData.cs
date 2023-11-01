using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapData : MonoBehaviour
{ 
    struct StageData
    {
        int startX;
        int startY;
        int rangeX;
        int rangeY;
    }
    int[,] stage;

    private void Start()
    {
        stage = new int[100,100];
    }

    
}
