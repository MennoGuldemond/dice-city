public class TransactionState : ITurnState
{
    public ITurnState DoState(TurnStateController turnState)
    {
        // handle transactions
        return turnState.transactionState;
    }
}
