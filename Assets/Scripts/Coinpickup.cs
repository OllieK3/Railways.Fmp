using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coinpickup : MonoBehaviour
{
    public int points;
    public TextMeshProUGUI coinCounter;
    public Spawntrain numb;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("collectable"))
        {
            points = points + 1;
            coinCounter.SetText(points.ToString());

            numb.GetComponent<Spawntrain>().current++;

            GameObject coin = other.gameObject;

            Destroy(other.gameObject);
        }
    }
}
