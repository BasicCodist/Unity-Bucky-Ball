using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUI : MonoBehaviour
{
    [SerializeField]
    public GameObject levelCompletePanel;
    public void LevelComplete()
    {
        levelCompletePanel.SetActive(true);
    }
}
