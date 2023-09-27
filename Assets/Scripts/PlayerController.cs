using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 15.0f;
    public float xRange = 30;

    public float zBoundTop = 14f;

    public float zBoundBottom = -4.5f;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    
    {
    }

    // Update is called once per frame
    void Update()
    {
        //stop the player from going off screen to the left
        if (transform.position.x < -xRange){
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);

        }
        //stop the player going off the screen to the right
        if (transform.position.x > xRange){
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);

        }
        //stop the player going off the screen top and bottom
        if (transform.position.z >= zBoundTop){
            transform.position =new Vector3 (transform.position.x, transform.position.y, zBoundTop);
        }
        if (transform.position.z <= zBoundBottom){
            transform.position =new Vector3 (transform.position.x, transform.position.y,zBoundBottom);
        }
        //get the input from the player to move player object
        horizontalInput = Input.GetAxis ("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        verticalInput = Input.GetAxis ("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
        

        //launch a projectile from the player when they press the space bar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //spawn projectile food from the player's position
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }

}
