using Cinemachine.Utility;
using UnityEngine;

public class Draggable : MonoBehaviour
{
	private Vector3 currentPosition;
	private Vector3 newPosition;
	private Camera cam;
	
	void Start ()
	{
		cam = Camera.main;
	}

	private void OnMouseDown()
	{
		currentPosition = transform.position - cam.ScreenToWorldPoint(Input.mousePosition);
	}

	private void OnMouseDrag()
	{
		newPosition = currentPosition + cam.ScreenToWorldPoint(Input.mousePosition);
		newPosition.z = 0;
		transform.position = newPosition;
	}
}
