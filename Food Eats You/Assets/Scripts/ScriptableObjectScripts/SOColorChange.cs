using UnityEngine;
[CreateAssetMenu(fileName = "NewColorChange", menuName = "Scriptable Objects/SOColorChange")]
public class SOColorChange : ScriptableObject
{
    public SOColor Color;

    public void Call(SpriteRenderer spriteRenderer)
    {
        spriteRenderer.color = Color.Value;
    }

    public void Call(Material material)
    {
        material.color = Color.Value;
    }
}
