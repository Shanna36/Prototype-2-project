using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        //destroy both food (gameObject) and animal (other.gameObject) when a collision happens between the two
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
