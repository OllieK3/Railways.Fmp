using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
	public GameObject pickupTxt, keyCard, Door;
	public float OnScreen = 2f;

	float time;

	bool On;

	private void Start()
	{
		pickupTxt.SetActive(false);
		keyCard.SetActive(true);
		Door.SetActive(true);
		On = false;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			pickupTxt.SetActive(true);
			Debug.Log("picked up");
			On = true;
			keyCard.SetActive(false);
			Door.SetActive(false);
			time = 0;
		}
	}

	private void Update()
	{
		time += Time.deltaTime;

		if (time > OnScreen && On == true)
		{
			pickupTxt.SetActive(false);
		}
	}
}
