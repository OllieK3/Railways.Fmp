using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextonTrigger : MonoBehaviour
{
    public GameObject UiObject;
    void Start()
    {
    UiObject.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
    if (other.tag == "Player")
    {
        UiObject.SetActive(true);
            
            StartCoroutine(joe());
        }
    }
   
    void Update()
    {
        
    }  
    void OnTriggerExit(Collider other)
    {
    UiObject.SetActive(false);
    
    }
    IEnumerator joe()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Menu scene");
    }
}
