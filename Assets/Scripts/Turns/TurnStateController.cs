using UnityEngine;

public class TurnStateController : MonoBehaviour
{
    [SerializeField]
    private string currentStateName;
    private ITurnState currentState;

    public RollDiceState rollDiceState = new RollDiceState();
    public TransactionState transactionState = new TransactionState();
    public DevelopmentState developmentState = new DevelopmentState();

    // Dice variables
    public GameObject dicePrefab;
    public Dice dice;

    void Start()
    {
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
        GameObject canvas = GameObject.FindGameObjectWithTag("MainCanvas");
        dice = GameObject.Instantiate(
            dicePrefab,
            canvas.transform
        ).GetComponent<Dice>();
    }
}
