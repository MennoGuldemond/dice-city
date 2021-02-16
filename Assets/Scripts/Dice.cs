using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour {
    public int result = 0;
    private Sprite[] diceSides;
    private Image image;

	void Start () {
        image = GetComponent<Image>();
        diceSides = Resources.LoadAll<Sprite>("Dice");
	}
	
    public void Roll()
    {
        StartCoroutine("RollDice");
    }

    // Coroutine that rolls the dice
    private IEnumerator RollDice()
    {
        // Variable to contain random dice side number.
        // It needs to be assigned. Let it be 0 initially
        int randomDiceSide = 0;

        // Loop to switch dice sides ramdomly
        // before final side appears. 20 itterations here.
        for (int i = 0; i <= 20; i++)
        {
            randomDiceSide = Random.Range(0, 5);
            image.sprite = diceSides[randomDiceSide];
            yield return new WaitForSeconds(0.05f);
        }

        result = randomDiceSide + 1;
    }
}
