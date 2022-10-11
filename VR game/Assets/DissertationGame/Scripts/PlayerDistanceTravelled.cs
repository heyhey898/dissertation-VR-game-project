using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerDistanceTravelled : MonoBehaviour
{
    /*
    [SerializeField] private Spawner spawner;
    [SerializeField] private Image timerImage;
    [SerializeField] private float gameTime;
    private float sliderCurrentFillAmout = 1f;

    [Header("Score Components")]
    [SerializeField] private TextMeshProUGUI cubeScoreText;
    [SerializeField] private TextMeshProUGUI coinScoreText;
    [SerializeField] private TextMeshProUGUI shotsFiredText;
    [SerializeField] private TextMeshProUGUI distanceTravlledText;

    [Header("Game Over Screen")]
    [SerializeField] private GameObject gameOverScreen;



    private int cubeScore;
    private int coinScore;
    private int shotsFired;
    private Vector3 lastPosition;
    private float distanceTravelled;

    [SerializeField] private GameObject teleport;
    [SerializeField] private GameObject joystick;
    [SerializeField] private GameObject armSwing;
    [SerializeField] private GameObject player;

    public enum GameState
    {
        Waiting,
        Playing,
        GameOver
    }

    public static GameState currentGameStatus;

    private void Awake()
    {
        currentGameStatus = GameState.Waiting;
    }

    private void Start()
    {
        lastPosition = player.transform.position;
    }

    private void Update()
    {
        if (currentGameStatus == GameState.Playing)
            AdjustTimer();

        float distance = Vector3.Distance(lastPosition, player.transform.position);
        distanceTravelled += distance;
        lastPosition = player.transform.position;
        Debug.Log(lastPosition);
        UpdateDistanceTravelled();

    }

    private void AdjustTimer()
    {
        timerImage.fillAmount = sliderCurrentFillAmout - (Time.deltaTime / gameTime);

        sliderCurrentFillAmout = timerImage.fillAmount;

        if (sliderCurrentFillAmout <= 0f)
        {
            GameOver();
        }
    }

    public void UpdateCubeScore()
    {
        if (currentGameStatus != GameState.Playing)
            return;
        cubeScore += 1;
        cubeScoreText.text = cubeScore.ToString();
    }

    public void UpdateCoinScore()
    {
        if (currentGameStatus != GameState.Playing)
            return;
        coinScore += 1;
        coinScoreText.text = coinScore.ToString();
    }

    public void UpdateShotsFired()
    {
        if (currentGameStatus != GameState.Playing)
            return;
        shotsFired += 1;
        shotsFiredText.text = shotsFired.ToString();
    }

    public void UpdateDistanceTravelled()
    {
        if (currentGameStatus != GameState.Playing)
            return;
        distanceTravlledText.text = distanceTravelled.ToString();
    }

    public void StartModeOne()
    {
        currentGameStatus = GameState.Playing;
        armSwing.SetActive(false);
        joystick.SetActive(false);
        spawner.SpawnAsteriod();
    }

    public void StartModeTwo()
    {
        currentGameStatus = GameState.Playing;
        teleport.SetActive(false);
        joystick.SetActive(false);
        spawner.SpawnAsteriod();
    }

    public void StartModeThree()
    {
        currentGameStatus = GameState.Playing;
        armSwing.SetActive(false);
        joystick.SetActive(false);
        spawner.SpawnAsteriod();
    }

    public void StartModeFour()
    {
        currentGameStatus = GameState.Playing;
        spawner.SpawnAsteriod();
    }

    public void ResetGame()
    {
        currentGameStatus = GameState.Waiting;

        //put timer back to 1 and reset scores
        cubeScore = 0;
        coinScore = 0;
        shotsFired = 0;

        cubeScoreText.text = "0";
        coinScoreText.text = "0";
        shotsFiredText.text = "0";

        sliderCurrentFillAmout = 1f;
        timerImage.fillAmount = 1f;


    }

    private void GameOver()
    {
        currentGameStatus = GameState.GameOver;

        //Show the game over screen
        gameOverScreen.SetActive(true);
        player.transform.position = new Vector3(0f, 0.445f, 0f);
        teleport.SetActive(false);
        armSwing.SetActive(false);
        joystick.SetActive(false);
    }

    */
}
