using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalForward : MonoBehaviour
{
    public float speed = 10.0f;
    private float topBoundUp = 32;
    private float topBoundDown = -22;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed  * Time.deltaTime);
        if (transform.position.z > topBoundUp || transform.position.z < topBoundDown)
        {
            Destroy(gameObject);
        }

    }
}