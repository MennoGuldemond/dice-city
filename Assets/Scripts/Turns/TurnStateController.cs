using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CardController))]
[RequireComponent(typeof(GameController))]
public class TurnStateController : MonoBehaviour
{
    [SerializeField]
    private string currentStateName;
    private ITurnState currentState;

    public CardController cardController;

    public RollDiceState rollDiceState = new RollDiceState();
    public TransactionState transactionState = new TransactionState();
    public DevelopmentState developmentState = new DevelopmentState();

    // Dice vars
    public GameObject dicePrefab;
    public Dice dice;

    void Start()
    {
        cardController = GetComponent<CardController>();

        CreateDice();
        currentState = rollDiceState;
    }

    void Update()
    {
        currentState = currentState.DoState(this);
        currentStateName = currentState.ToString();
    }

    private void CreateDice()
    {
        GameObject canvasGO = GameObject.FindGameObjectWithTag("MainCanvas");
        dice = GameObject.Instantiate(
            dicePrefab,
            canvasGO.transform
        ).GetComponent<Dice>();
    }
}