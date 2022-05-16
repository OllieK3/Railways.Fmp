 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCinteraction : MonoBehaviour
{
    public GameObject textbox, buttonPrompt;

    private bool talking;
    private int inTriggerCount;
    
    void Awake()
    {
        textbox.SetActive(false);
        buttonPrompt.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            textbox.SetActive(false);
            buttonPrompt.SetActive(true);

            inTriggerCount++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inTriggerCount--;

            if (inTriggerCount == 0)
            {
                textbox.SetActive(false);
                buttonPrompt.SetActive(false);
                talking = false;
            }
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) { // Only when first pressed
            if (talking)
            {
                textbox.SetActive(false);
                buttonPrompt.SetActive(true);
            }
            else
            {
                textbox.SetActive(true);
                buttonPrompt.SetActive(false);
            }
            talking = !talking;
        }
    }
}
