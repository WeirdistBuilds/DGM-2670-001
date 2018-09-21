using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour {

	
	private CharacterController controller;
	public MovePattern pattern;
	public Text text;
	private int number;

	void Start()
	{
		controller = GetComponent<CharacterController>();
		number = 0;
	}
	
	void Update()
	{
		pattern.Invoke(controller, transform);
	}

	void OnTriggerEnter()
	{
		number++;
		text.text = number.ToString();
	}
}
