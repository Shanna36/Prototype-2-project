using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{// define the top and bottom boundaries so instantiated objects don't move beyond the play area
    private float topBound = 35.0f;
    private float lowerBound = -15.0f;

    private float sideBound = 30f;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    { // use logic that if the game object goes above the top bound or below the lower bound, to destory it
        if (transform.position.z > topBound)
        {
            Destroy (gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            gameManager.AddLives(-1); //says add lives but really you are subtracting
            Destroy (gameObject);
        }
        else if (transform.position.x > sideBound){
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (transform.position.x < -sideBound){
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
    }
}
