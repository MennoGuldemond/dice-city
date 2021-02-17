public class DevelopmentState : ITurnState
{
    public ITurnState DoState(TurnStateController turnState)
    {
        if (turnState.cardController.isReset == false)
        {
            turnState.cardController.Reset();
        }
        if (turnState.cardController.drawingCards == false &&
            turnState.cardController.cardPicked == false)
        {
            turnState.cardController.ShowCards();
            return turnState.developmentState;
        }
        else if (turnState.cardController.cardPicked == false)
        {
            return turnState.developmentState;
        }
        else
        {
            turnState.cardController.isReset = false;
            return turnState.rollDiceState;
        }

    }
}
