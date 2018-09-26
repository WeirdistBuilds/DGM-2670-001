using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunCountDown : MonoBehaviour
{
	private Text label;
	
	IEnumerator Start ()
	{
		
		label = GetComponent<Text>();
		int number = 100;

		while (number > 0)
		{
			label.text = number.ToString();
			yield return new WaitForSeconds(0.1f);
			number--;
		}
		label.text = "GO!";
		
	}
	
}
