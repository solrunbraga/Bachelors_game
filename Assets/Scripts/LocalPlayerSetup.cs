using UnityEngine;
using UnityEngine.InputSystem;

public class LocalPlayerSetup : MonoBehaviour
{
    public enum GameMode
    {
        PvE,
        PvP
    }

    [SerializeField] private GameMode gameMode;

    [Header("Players")]
    [SerializeField] private PlayerInput player1;
    [SerializeField] private PlayerInput player2;

    [Header("Spawn Points")]
    [SerializeField] private Transform player1Spawn;
    [SerializeField] private Transform player2Spawn;

    private void Start()
    {
        // Player 1
        player1.gameObject.SetActive(true);
        player1.transform.position = player1Spawn.position;

        if (gameMode == GameMode.PvP)
        {
            SetupPvP();
        }
        else
        {
            SetupPvE();
        }
    }

    private void SetupPvP()
    {
        player2.gameObject.SetActive(true);
        player2.transform.position = player2Spawn.position;
    }

    private void SetupPvE()
    {
        player2.gameObject.SetActive(false);
    }


}
