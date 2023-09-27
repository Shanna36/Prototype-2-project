using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{// define the top and bottom boundaries so instantiated objects don't move beyond the play area
    private float topBound = 35.0f;
    private float lowerBound = -15.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { // use logic that if the gam object goes above the top bound or below the lower bound, to destory it
        if (transform.position.z > topBound)
        {
            Destroy (gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!"); //if an animal makes it to the bottom bound, it is game over!
            Destroy (gameObject);
        }
    }
}
