using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
	private Text textToChange;
	public SOInt kills;
 
	void Start () {
		textToChange = gameObject.GetComponent<Text>(); 
		textToChange.text = kills.Value.ToString();
	}
     
	void Update () {
		textToChange.text = kills.Value.ToString(); 
	}
}