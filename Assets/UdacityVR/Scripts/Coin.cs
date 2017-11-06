using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
    public GameObject coinPoofPrefab;

    private GameState gameState;

    private void Awake()
    {
        gameState = GameObject.FindGameObjectWithTag("GameState").GetComponent<GameState>();
    }

    public void OnCoinClicked() {
        Debug.Log("Coin clicked");

        // Instantiate the CoinPoof Prefab where this coin is located
        Instantiate(coinPoofPrefab);
        coinPoofPrefab.transform.position = transform.position;

        // Make sure the poof animates vertically
        // it does by default, nothing to do

        // Destroy this coin. Check the Unity documentation on how to use Destroy
        Destroy(gameObject);
        gameState.updateCollectiblesTracking();
    }

}
