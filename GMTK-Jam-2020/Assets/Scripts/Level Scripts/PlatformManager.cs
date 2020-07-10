﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    // Array setup for platforms
    GameObject[] platforms;
    GameObject currentPlatform;
    int index;

    // GameObject for the collision of currently selected platform
    public GameObject currentPlatCol;


    // Start is called before the first frame update
    void Start()
    {
        platforms = GameObject.FindGameObjectsWithTag("platform"); // Creates an array of all objects with the tag platform
        index = Random.Range(0, platforms.Length); // randomly selects one platform
        currentPlatform = platforms[index]; // registers random platform as the one the player must get to
        print(currentPlatform.name); // Prints name for debug purposes
        currentPlatCol.transform.position = new Vector2 (currentPlatform.transform.position.x, currentPlatform.transform.position.y + .25f); // Moves collission to platform and adds height
                                                                                                                                             // to make it only reachable from the top
    }

    // Function repeats the process above
    public void NewPlatform()
    {
      index = Random.Range(0, platforms.Length);
      currentPlatform = platforms[index];
      currentPlatCol.transform.position = new Vector2(currentPlatform.transform.position.x, currentPlatform.transform.position.y + .25f);
    }
}
