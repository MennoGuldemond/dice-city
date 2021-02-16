using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour {
    public int result = 0;
    private Sprite[] diceSideSprites;
    private Image image;

	void Start () {
        image = GetComponent<Image>();
        diceSideSprites = Resources.LoadAll<Sprite>("Dice");

        // Set initial sprite to dice 6.
        image.sprite = diceSideSprites[5];
	}
	
    public void Roll()
    {
        StartCoroutine("RollDice");
    }

    private IEnumerator RollDice()
    {
        // Variable to contain random dice side number.
        int randomDiceSide = 0;

        // Loop to switch dice sides ramdomly before final side appears.
        for (int i = 0; i <= 20; i++)
        {
            randomDiceSide = Random.Range(0, 5);
            image.sprite = diceSideSprites[randomDiceSide];
            yield return new WaitForSeconds(0.05f);
        }

        result = randomDiceSide + 1;
    }
}
