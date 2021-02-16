using UnityEngine;
using UnityEngine.UI;

class CardDisplay : MonoBehaviour {

    public CardScriptableObject card;

    public Text nameText;
    public Text descriptionText;

    public Image artImage;
    public Image backgroundImage;

    public Text costText;
    public Text gainText;

    public void Start() {
        nameText.text = card.name;
        descriptionText.text = card.description;

        artImage.sprite = card.art;
        backgroundImage.color = card.color;

        costText.text = card.cost.ToString();
        gainText.text = card.gain.ToString();
    }

}
