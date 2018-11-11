using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
	private Text textToChange;
	public SOInt change;
 
	void Start () {
		textToChange = gameObject.GetComponent<Text>(); 
		textToChange.text = change.Value.ToString();
	}
     
	void Update () {
		textToChange.text = change.Value.ToString(); 
	}
}