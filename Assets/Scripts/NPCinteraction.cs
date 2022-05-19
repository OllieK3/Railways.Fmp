using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPCinteraction : MonoBehaviour
{
    public GameObject buttonPrompt;
    public TextMeshProUGUI textbox;

    [TextArea(3, 20)]
    public string message;

    private bool talking;
    private int inTriggerCount;

    void Awake()
    {
        textbox.gameObject.SetActive(false);
        buttonPrompt.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            textbox.gameObject.SetActive(false);
            textbox.text = message;
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
                textbox.gameObject.SetActive(false);
                buttonPrompt.SetActive(false);
                talking = false;
            }
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        { // Only when first pressed
            if (talking)
            {
                textbox.gameObject.SetActive(false);
                buttonPrompt.SetActive(true);
            }
            else
            {
                textbox.gameObject.SetActive(true);
                buttonPrompt.SetActive(false);
            }
            talking = !talking;
        }
    }
}
