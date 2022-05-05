using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public CharacterController controller;
    public Transform teleportDest;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            controller.enabled = false;
            controller.gameObject.transform.position = teleportDest.position; //new Vector3(339, -2, -185);
            controller.enabled = true;
        }
    }
}