using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    public bool isReset = false;
    public bool cardPicked = false;
    public bool drawingCards = false;

    public List<CardScriptableObject> allCards = new List<CardScriptableObject>();
    public GameObject cardPrefab;

    private GameObject cardPickerPanelGO;

    void Start()
    {
        if (cardPrefab == null)
        {
            Debug.LogError("CardController: cardPrefab can not be null.");
        }
        cardPickerPanelGO = GameObject.FindGameObjectWithTag("CardPickerPanel");
        cardPickerPanelGO.SetActive(false);
    }

    public void Reset()
    {
        isReset = true;
        cardPicked = false;
        drawingCards = false;

        foreach (Transform child in cardPickerPanelGO.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }

    public void CardChosen(CardDisplay card)
    {
        // Give card to the current player?
        Debug.Log(string.Format("{0} was chosen!", card.name));
        cardPicked = true;
        cardPickerPanelGO.SetActive(false);
    }

    public void ShowCards()
    {
        drawingCards = true;
        cardPickerPanelGO.SetActive(true);
        var cards = GetRandomCards(4);
        StartCoroutine(DrawCards(cards));
    }

    public CardScriptableObject[] GetRandomCards(int amount)
    {
        var chosenCards = new CardScriptableObject[amount];

        for (int i = 0; i < amount; i++)
        {
            int randomIndex = Random.Range(0, allCards.Count);
            chosenCards[i] = allCards[randomIndex];
        }

        return chosenCards;
    }

    private IEnumerator DrawCards(CardScriptableObject[] cards)
    {
        for (int i = 0; i < cards.Length; i++)
        {
            GameObject cardGO = GameObject.Instantiate(cardPrefab, cardPickerPanelGO.transform);
            var cardDisplay = cardGO.GetComponent<CardDisplay>();
            cardDisplay.card = cards[i];
            cardDisplay.cardController = this;
            yield return new WaitForSeconds(.3f);
        }
    }
}
