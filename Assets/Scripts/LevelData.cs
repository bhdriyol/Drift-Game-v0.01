using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelData : MonoBehaviour
{
    [Space(10)]
    [Header("Level Variables")]
    public int levelNumber;
    public int lapCount;
    public int levelMaxLap;
    public bool levelDone = false;
    public bool finalLap = false;
    [Space(10)]
    [Header("UI Elements")]
    public Text lapCountText;
    public GameObject winUI;
    public GameObject speedUI;
    public GameObject scoreUI;
    public GameObject lapUI;
    public GameObject coinUI;
    [Space(10)]
    [Header("Checkpoints")]
    public GameObject[] checkpointObj;
    public int checkpointCount;
    public int triggeredCheckpointCount;


    private void Start()
    {
        checkpointObj = GameObject.FindGameObjectsWithTag("Checkpoint");
        checkpointCount = checkpointObj.Length;
        lapCountText.text = lapCount.ToString() + " / " + levelMaxLap;
    }

    private void Update()
    {
        //lapCount = Mathf.Clamp(lapCount, 1, levelMaxLap);
        if (lapCount == levelMaxLap&&triggeredCheckpointCount==checkpointCount)  
        {
            finalLap = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (triggeredCheckpointCount == checkpointCount)
        {
            if (other.tag == "Car")
            {
                if (lapCount!=levelMaxLap)
                {
                    lapCount++;
                    lapCountText.text = lapCount.ToString() + " / " + levelMaxLap;
                }
                triggeredCheckpointCount = 0;
                if (finalLap == true)
                {
                    levelDone = true;
                    winUI.SetActive(true);
                    speedUI.SetActive(false);
                    scoreUI.SetActive(false);
                    lapUI.SetActive(false);
                    coinUI.SetActive(false);
                }
            }
        }

    }
}
