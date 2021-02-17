using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class CardScriptableObject : ScriptableObject
{
    public int amountInGame;
    public new string name;
    public string description;

    public Color32 color;

    public Sprite art;

    public int cost;
    public int gain;
    public List<int> triggers;
    public string triggerText;

    public abstract void Use();
}