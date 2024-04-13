using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleGameOjects : MonoBehaviour
{
    public GameObject[] objectsToToggle; // Array of game objects to toggle

    void Update()
    {
        // Check if the left mouse button is clicked
        if (Input.GetMouseButtonDown(0))
        {
            // Cast a ray from the mouse position into the scene
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Check if the ray hits any game object
            if (Physics.Raycast(ray, out hit))
            {
                // Check if the clicked game object has this script attached
                toggleGameOjects toggleScript = hit.collider.GetComponent<toggleGameOjects>();

                if (toggleScript != null)
                {
                    // Toggle the active state of the game objects
                    ToggleObjects();
                }
            }
        }
    }

    void ToggleObjects()
    {
        // Iterate through each game object in the array
        foreach (GameObject obj in objectsToToggle)
        {
            // Toggle the active state of the game object
            obj.SetActive(!obj.activeSelf);
        }
    }
}
