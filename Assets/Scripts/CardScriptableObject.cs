using System.Collections.Generic;
using UnityEngine;

public abstract class CardScriptableObject : ScriptableObject
{
    public new string name;
    public string description;

    public Color32 color;

    public Sprite art;

    public int cost;
    public int gain;
    public List<int> triggers;

    public abstract void Use();

    public string GetTriggerText() {
        return triggers.ToString();
    }
}
