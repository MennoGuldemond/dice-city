using TMPro;
using UnityEngine;
using UnityEngine.UI;

class CardDisplay : MonoBehaviour
{
    public CardScriptableObject card;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;

    public Image artImage;
    public Image backgroundImage;

    public TextMeshProUGUI costText;
    public TextMeshProUGUI gainText;
    public TextMeshProUGUI triggerText;

    public void Start()
    {
        nameText.text = card.name;
        descriptionText.text = card.description;

        artImage.sprite = card.art;
        backgroundImage.color = card.color;

        costText.text = card.cost.ToString();
        gainText.text = card.gain.ToString();
        triggerText.text = card.triggerText;
    }

}