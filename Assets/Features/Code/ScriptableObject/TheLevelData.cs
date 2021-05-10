using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TheLevelData", menuName = "ScriptableObjects/Level")]
public class TheLevelData : ScriptableObject
{
    public float startingScrollingSpeed;
    public float currentScrollingSpeed;
}