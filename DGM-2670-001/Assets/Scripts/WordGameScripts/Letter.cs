using UnityEngine;
using Words;

[CreateAssetMenu(fileName ="Letter")]
public class Letter : ScriptableObject
{
    public Letters.LetterSelection Value;
}
