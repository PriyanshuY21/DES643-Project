using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIswitcher : MonoBehaviour
{
    public GameObject UI;

    void Start()
    {
        UI.SetActive(false);
    }

    void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("Main"))
        {
            UI.SetActive(true);
            StartCoroutine(WaitForSec());
        }
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(3);
        Destroy(UI);
    }
}
