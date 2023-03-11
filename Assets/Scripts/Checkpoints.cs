using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    public LevelData finishLine;

    private void Start()
    {
        finishLine = gameObject.GetComponentInParent<LevelData>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Car")
        {
            finishLine.triggeredCheckpointCount++;
        }
    }
}
