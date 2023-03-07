using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontal = 0;
    public float speed = 10.0f;
    public float xRange = 23.72107f;
    private float topBound = 30;

    public GameObject PizzaPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right* speed*horizontal*Time.deltaTime);

        if(transform.position.x> xRange)
        {
            transform.position=new Vector3(xRange, transform.position.y,transform.position.z);
        }
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(PizzaPrefab, transform.position, PizzaPrefab.transform.rotation);
        }
        //if (transform.position.z > topBound)
        //{
        //    Destroy(PizzaPrefab);
        //}
    }
}
