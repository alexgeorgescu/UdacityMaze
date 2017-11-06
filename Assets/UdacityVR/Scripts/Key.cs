using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
    public GameObject keyPoofPrefab;
    public GameObject door;

    private GameState gameState;

    private void Awake()
    {
        gameState = GameObject.FindGameObjectWithTag("GameState").GetComponent<GameState>();
    }

    void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
        Instantiate(keyPoofPrefab, transform.position, transform.rotation);
        
        // Make sure the poof animates vertically
        // it does, nothing to do

        // Call the Unlock() method on the Door
        door.GetComponent<Door>().Unlock();

        // Set the Key Collected Variable to true
        gameState.setKeyCollected(true);

        // Destroy the key. Check the Unity documentation on how to use Destroy
        Destroy(gameObject);
    }

}
