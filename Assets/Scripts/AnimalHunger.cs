using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalHunger : MonoBehaviour
{
    public Slider hungerSlider;
    public int amountToFeed;

    private int currentFedAmount = 0;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        if (hungerSlider != null)
        {
        hungerSlider.maxValue = amountToFeed;
        hungerSlider.value = 0;
        hungerSlider.fillRect.gameObject.SetActive(false);
        }
        else 
        {
            Debug.LogError ("hungerSlider is not assigned in the inspector");
        }
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FeedAnimal(int amountToFeed)
{
    Debug.Log($"Feeding animal: {amountToFeed}");
    currentFedAmount += amountToFeed;
    Debug.Log ($"Current Fed Amount: {currentFedAmount}");
    hungerSlider.fillRect.gameObject.SetActive(true);
    hungerSlider.value = currentFedAmount;

    if (currentFedAmount >= hungerSlider.maxValue)
    {
        gameManager.AddScore(amountToFeed);
        Destroy(gameObject, 0.1f);
    }
}
}
