using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    public GameObject platformPrefab;
    public GameObject platformPrefab2;

    public int numberOfPlatforms;
    public float levelWidth = 3f;
    public float color;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += 0.7f;
            color = Random.Range(1, 3);
            if (color <= 1)
            {
                Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            }
            else if (color <= 2)
            {
                Instantiate(platformPrefab2, spawnPosition, Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
