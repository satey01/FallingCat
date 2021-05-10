using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerType : MonoBehaviour
{
    [Header("Time before the speed came back to normal")]
    public float m_timeBeforeSlowDown;

    private float _timeOfNextBullet;

    private float _previousSpeed;

    public void Start()
    {
        _timeOfNextBullet = Time.time;
    }

    private void IncrementTimer()
    {
        _timeOfNextBullet = Time.time + m_timeBeforeSlowDown;
    }

    private void FixedUpdate()
    {
        if (!(Time.time > _timeOfNextBullet)) return;

        IncrementTimer();
    }

    #region Tools

    public void dynamite(PlayerData _player, string _tagName)
    {
        Debug.Log($"i hited a {_tagName} and i get a new boom boom");
        _player.dynamiteCounter += 1;
    }

    public void WaterTear(TheLevelData _level)
    {
        Debug.Log($"WaterTear  : i speed up");

        _level.scrollingSpeed = 50.0f;
    }

    public void Balloon()
    {
        Debug.Log($"Balloon : i slow down");
    }

    public void Invulnerability()
    {
        Debug.Log($"Invulnerability : i took a bread");
    }

    public void Freezed()
    {
        Debug.Log($"Freezed : i took weed");
    }

    #endregion Tools
}