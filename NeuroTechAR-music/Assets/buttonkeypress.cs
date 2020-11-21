using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class buttonkeypress : MonoBehaviour
{
	public string key;


	public void Update()
	{

		if (Input.GetButtonDown(key))
		{

			EventSystem.current.SetSelectedGameObject(this.gameObject);
		}
	}
}
