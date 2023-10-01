using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private GameManager gameManager;

    void Awake()
{
    // intermittently losing Game Manager script during gameplay, trying to resolve by moving call to Game Manager to awake instead of start
    if (gameManager == null)
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); 
        if (gameManager == null)
        {
            Debug.LogError("GameManager not found!"); // trying to solve a null object error in my scene
        }
    }
}

void Start()
{

}

private void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Player"))
    {
        gameManager.AddLives(-1);
        Destroy(gameObject);
    }
    else if (other.CompareTag("Animal"))
    {
       other.GetComponent<AnimalHunger>().FeedAnimal(1);
        Destroy(gameObject);
      
    }
}
}