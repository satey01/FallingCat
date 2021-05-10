using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "ScriptableObjects/Player")]
public class PlayerData : ScriptableObject
{
    public string playerName;
    public float score;

    public int dynamiteCounter;
}