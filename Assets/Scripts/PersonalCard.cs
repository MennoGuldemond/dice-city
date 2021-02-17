using UnityEngine;

[CreateAssetMenu(fileName = "new Personal Card", menuName = "Card/Personal")]
public class PersonalCard : CardScriptableObject
{
    public override void Use()
    {
        Debug.Log("Hi, I'm a Personal Card");
    }
}
