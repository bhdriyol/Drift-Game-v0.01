using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinUIManager : MonoBehaviour
{
    [Header("UI Elements")]
    public Text levelNumberText;
    public Text scoreText;
    public Text coinText;
    [Space(10)]
    [Header("Needs")]
    public PrometeoCarController carController;
    public LevelData levelData;

    private void OnEnable()
    {
        carController = GameObject.FindGameObjectWithTag("Car").GetComponent<PrometeoCarController>();
        levelData = GameObject.Find("Finish Line").GetComponent<LevelData>();

        levelNumberText.text = "Level "+levelData.levelNumber.ToString();
        scoreText.text = carController.driftScore.ToString();
        coinText.text = "X" + carController.coinCount.ToString();
    }
}
