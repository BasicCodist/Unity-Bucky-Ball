using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucket : MonoBehaviour
{
    [SerializeField]
    public LevelUI levelUI;
    void OnCollisionEnter(Collision collision)
    {
        levelUI.LevelComplete();
    }
}
