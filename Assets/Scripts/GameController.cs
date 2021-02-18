using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TurnState
{
    DICE,
    TRANSACTION,
    DEVELOPMENT
}

public class GameController : MonoBehaviour
{
    public Player activePlayer;
    List<Player> players;
    public int amountOfOpponents;

    void Start()
    {
        // players = new List<Player>();
        // players.Add(new Player(0, false));
        // for (int i = 1; i < amountOfOpponents + 1; i++)
        // {
        //     players.Add(new Player(i, true));
        // }
        // activePlayer = players[0];
    }

    public void NextPlayer()
    {
        if (activePlayer.number < players.Count - 1)
        {
            activePlayer = players[activePlayer.number + 1];
        }
        else
        {
            activePlayer = players[0];
        }
    }
}