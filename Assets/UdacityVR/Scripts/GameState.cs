using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour {

    public bool keyCollected = false;
    public GameObject collectibles;
    public TextMesh collectiblesText;
    public TextMesh keyText;

    private int totalCollectiblesAtStart;
    private int currentCollectiblesCount;

    private void Start()
    {
        totalCollectiblesAtStart = collectibles.transform.childCount;
        keyText.text = "\nNo key";
        collectiblesText.text = "0 of " + totalCollectiblesAtStart + " collectibles found!\n";
    }

    public void setKeyCollected(bool state)
    {
        keyCollected = state;
        if (keyCollected)
            keyText.text = "\nKey found!";
        else
            keyText.text = "\nNo key";
    }

    public void updateCollectiblesTracking()
    {
        currentCollectiblesCount = totalCollectiblesAtStart - collectibles.transform.childCount + 1;
        Debug.Log("You have found " + currentCollectiblesCount + " out of " + totalCollectiblesAtStart);
        collectiblesText.text = currentCollectiblesCount + " of " + totalCollectiblesAtStart + " collectibles found!\n";
    }



}
