using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    // Create a boolean value called "opening" that can be checked in Update()
    public bool locked = true;
    public bool opening = false;
    public float doorOpeningPosition = 7.5f;
    public float openingSpeed = 3f;
    
    void Update() {
        // If the door is opening and it is not fully raised
        // Animate the door raising up
        if (opening)
            transform.position = Vector3.Lerp(transform.position, 
                new Vector3(transform.position.x, doorOpeningPosition, transform.position.z), 
                Time.deltaTime * openingSpeed);
    }

    public void OnDoorClicked() {
        // If the door is clicked and unlocked
        // Set the "opening" boolean to true
        // (optionally) Else
        // Play a sound to indicate the door is locked
        if (!locked)
            opening = true;
        else
            ; // play sound
    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
        Debug.Log("Door has been unlocked!");
        locked = false;

    }
}
