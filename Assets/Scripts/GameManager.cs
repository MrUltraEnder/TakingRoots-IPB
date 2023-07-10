using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;


public enum GameState
{
    Selection,
    Game,
    Lobby,
    Store,
    Pause,
    GameOver
}

public class GameManager : MonoBehaviour
{
    public int DeadPlayers;
    public static GameManager gm;
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;
    private GameState _previousState;
    public GameState gameState;
    public UnityEvent OnLevelChange;

    private LevelManager _levelManager;

    private void Awake()
    {

        gm = this;
        _levelManager = FindObjectOfType<LevelManager>();
    }

    void Start()
    {

    }
    private void Update()
    {
        if (DeadPlayers == 2)
        {
            DeadPlayers = 0;
            OnLevelChange.Invoke();
        }
    }
    public void StartSelection()
    {
        if (_levelManager.levelSelector.scenesToLoad.Contains(SceneManager.GetActiveScene().name))
        {
            gameState = GameState.Selection;
        }
    }

    public void StartGame()
    {
        gameState = GameState.Game;
    }
    public void spawnPlayers()
    {
        player1.SetActive(true);
        player2.SetActive(true);
    }

    public void OnDeadPlayer()
    {
        DeadPlayers++;
    }

    public void PauseGameManager()
    {
        _previousState = gameState;
        gameState = GameState.Pause;
        Time.timeScale = 0;
    }
    public void ResumeGameManager()
    {
        gameState = _previousState;
        Time.timeScale = 1;
    }
}
