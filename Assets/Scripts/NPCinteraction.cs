using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCinteraction : MonoBehaviour
{
    public GameObject txt;
    
    void Start()

    {
        txt.SetActive(false);
    }
   
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                txt.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            txt.SetActive(true);
        }
    }
}
