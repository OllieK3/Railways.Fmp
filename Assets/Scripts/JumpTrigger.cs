using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTrigger : MonoBehaviour {

    public AudioSource Scream;
    public GameObject ThePlayer;
    public GameObject JumpCam;
    public GameObject Flashing;
    public GameObject Text;
    void OnTriggerEnter (Collider other) {
        if (other.gameObject.CompareTag("Player"))
        {
            Scream.Play();
            JumpCam.SetActive(true);
            ThePlayer.SetActive(false);
            Flashing.SetActive(true);
            Text.SetActive(true);
            StartCoroutine(EndJump());
        }
    } 
   
    IEnumerator EndJump() {
        yield return new WaitForSeconds(2f);
        ThePlayer.SetActive(true);
        JumpCam.SetActive(false);
        Flashing.SetActive(false);
        Text.SetActive(false);
    }
}
