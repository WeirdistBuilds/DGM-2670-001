using UnityEngine;

[CreateAssetMenu(fileName = "NewColor", menuName = "Scriptable Objects/SOColor")]
public class SOColor : ScriptableObject
{
    public Color Value = Color.white;
}
