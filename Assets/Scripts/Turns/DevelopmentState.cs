public class DevelopmentState : ITurnState
{
    public ITurnState DoState(TurnStateController turnState)
    {
        return turnState.developmentState;
    }
}
