public class RollDiceState : ITurnState
{
    public ITurnState DoState(TurnStateController turnState)
    {
        if (turnState.dice.isReset == false)
        {
            turnState.dice.Reset();
        }
        if (turnState.dice.gameObject.activeInHierarchy == false &&
            turnState.dice.hasRolled == false)
        {
            turnState.dice.gameObject.SetActive(true);
            return turnState.rollDiceState;
        }
        else if (turnState.dice.hasRolled == false)
        {
            return turnState.rollDiceState;
        }
        else
        {
            turnState.dice.isReset = false;
            return turnState.transactionState;
        }
    }
}
