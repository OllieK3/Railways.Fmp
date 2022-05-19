using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scenechanger : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("Main Level");
    }
}
