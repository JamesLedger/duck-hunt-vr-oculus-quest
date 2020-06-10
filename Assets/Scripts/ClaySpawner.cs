using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClaySpawner : MonoBehaviour
{
    public int counter = 0;
    public GameObject clay;
    public Transform spawnPoint;

    // Update is called once per frame
    void Update()
    {
        if (counter >= 100)
        {
            Instantiate(clay, spawnPoint);
            counter = 0;
        }
        else
        {
            counter++;
        }
    }
}
