using UnityEngine;

[CreateAssetMenu(fileName = "new Anybody Card", menuName = "Card/Anybody")]
public class AnybodyCard : CardScriptableObject
{
    public override void Use()
    {
        Debug.Log("Hi, I'm an Anybody Card");
    }
}
