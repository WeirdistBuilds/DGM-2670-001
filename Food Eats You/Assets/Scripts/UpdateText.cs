using UnityEngine;
using UnityEngine.UI;

public class UpdateText : MonoBehaviour
{
	public SOInt Data;
	private Text label;
	public bool isMoney;
	
	void Start ()
	{
		label = GetComponent<Text>();
	}

	void Update()
	{
		label.text = isMoney ? Data.Value.ToString("C0") : Data.Value.ToString();
	}
}
