using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalPrefabs : MonoBehaviour
{
    public GameObject[] AnimalPrefab = new GameObject[4];
    private float topBoundUp = 32;
    private float topBoundDown = -22;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnAnimals", 1f, 2f);
    }

    // Update is called once per frame
    void Update()
    {

        

    }


    void spawnAnimals()
    {
        var position = new Vector3(Random.Range(-22.43301f, 22.43301f), 0, Random.Range(-17.9f, 17.9f));
        var ind = Random.Range(0, 3);
        Instantiate(AnimalPrefab[ind], position, AnimalPrefab[ind].transform.rotation);
        //if (transform.position.z > topBoundUp || transform.position.z < topBoundDown)
        //{
        //    Destroy(test);
        //}
    }
}