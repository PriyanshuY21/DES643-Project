using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.XR;

public class toggleGameOjects : MonoBehaviour
{
    public GameObject[] objectsToToggle; // Array of game objects to toggle

   

    void Update()
    {
     
    }

    public void ToggleObjects()
    {
        // Iterate through each game object in the array
        foreach (GameObject obj in objectsToToggle)
        {
            // Toggle the active state of the game object
            obj.SetActive(!obj.activeSelf);
        }
    }
}
