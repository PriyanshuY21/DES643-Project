using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class TeleportationController : MonoBehaviour
{
    public XRController teleportController; // Reference to the XR controller used for teleportation
    public GameObject teleportReticlePrefab; // Prefab for the teleportation reticle

    private GameObject reticle; // Instance of the teleportation reticle
    private UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor rayInteractor; // Reference to the ray interactor of the teleportation controller

    void Start()
    {
        rayInteractor = teleportController.GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor>(); // Get the ray interactor

        // Instantiate the teleportation reticle
        reticle = Instantiate(teleportReticlePrefab);
        reticle.SetActive(false); // Initially hide the reticle
    }

    void Update()
    {
        // Check if the teleport button is pressed
        if (teleportController.inputDevice.TryGetFeatureValue(CommonUsages.secondaryButton, out bool isTeleportButtonDown) && isTeleportButtonDown)
        {
            StartTeleport();
        }
        else
        {
            CancelTeleport();
        }
    }

    void StartTeleport()
    {
        // Enable the reticle and ray interactor for teleportation
        reticle.SetActive(true);
        rayInteractor.enabled = true;
    }

    void CancelTeleport()
    {
        // Disable the reticle and ray interactor
        reticle.SetActive(false);
        rayInteractor.enabled = false;
    }
}
