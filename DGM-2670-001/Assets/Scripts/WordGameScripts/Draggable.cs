using Cinemachine.Utility;
using UnityEngine;
using System.Collections;

public class Draggable : MonoBehaviour
{
	private Vector3 offsetPosition;
	private Vector3 newPosition;
	private Camera cam;

	public bool CanDrag;
	
	void Start ()
	{
		cam = Camera.main;
	}

	public IEnumerator OnMouseDown()
	{
		offsetPosition = transform.position - cam.ScreenToWorldPoint(Input.mousePosition);
		yield return new WaitForFixedUpdate();
		CanDrag = true;
		while (CanDrag)
		{
			yield return new WaitForFixedUpdate();
			newPosition = cam.ScreenToWorldPoint(Input.mousePosition) + offsetPosition;
			transform.position = newPosition;
		}
	}

	private void OnMouseUp()
	{
		CanDrag = false;
	}
}
