using System;
using UnityEngine;

public class GameStateManager : StaticInstance<GameStateManager>
{
    public static event Action<GameState> OnBeforeStateChanged;
    public static event Action<GameState> OnAfterStateChanged;

    public GameState State { get; private set; }

    // Kick the game off with the first state
    void Start() => ChangeState(GameState.Starting);

    public void ChangeState(GameState newState)
    {
        OnBeforeStateChanged?.Invoke(newState);

        State = newState;
        switch (newState)
        {
            case GameState.Starting:
                HandleStarting();
                break;
            case GameState.Searching:
                break;
            case GameState.Ending:
                break;
            case GameState.PlayerTurn:
                break;
            case GameState.EnemyTurn:
                break;
            case GameState.Win:
                break;
            case GameState.Lose:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }

        OnAfterStateChanged?.Invoke(newState);

        Debug.Log($"New state: {newState}");
    }

    private void HandleStarting()
    {
        Debug.Log("Game is start");
    }
}

[Serializable]
public enum GameState
{
    Starting = 0,
    Searching = 1,
    Ending = 2,
    PlayerTurn = 3,
    EnemyTurn = 4,
    Win = 5,
    Lose = 6,
}
