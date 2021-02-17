using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public CardScriptableObject card;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;

    public Image artImage;
    public Image backgroundImage;

    public TextMeshProUGUI costText;
    public TextMeshProUGUI gainText;
    public TextMeshProUGUI triggerText;

    [HideInInspector]
    public CardController cardController;

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

    public void OnCardClick()
    {
        cardController.CardChosen(this);
    }

}