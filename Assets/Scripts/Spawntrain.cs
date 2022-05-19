using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawntrain : MonoBehaviour
{
    public float max = 6f;
    public float current;
    public GameObject train;

    private void Update()
    {
        if (current == max)
        {
            train.SetActive(true);
        }
    }
}
