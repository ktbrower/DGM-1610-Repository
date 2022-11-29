using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;


public class PlayerController : MonoBehaviour

{
    public float horizontalInput;
    public float speed = 10;
    public float xRange =47;

    public Transform blaster;
    public GameObject laserBolt;

    public GameManager gameManager;
    

    // Update is called once per frame
    void Update()
    
    {
        
        horizontalInput = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector3.right * (horizontalInput * Time.deltaTime * speed));

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation);
        }

       
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
