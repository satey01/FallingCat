using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerType : MonoBehaviour
{
    #region Exposed Members

    [Header("Time before the speed come back to normal")]
    public float m_timeBeforeSlowDown;

    [Header("Speed up value")]
    public float m_speedUpValue;

    [Header("Speed down value")]
    public float m_speedDownValue;

    #endregion Exposed Members

    #region Unity API

    public void Start()
    {
        _timeOfResumeSpeed = Time.time;
        _transform = GetComponent<Transform>();

        _player = GetComponent<PlayerCtrl>().player;
    }

    private void FixedUpdate()
    {
        if ((Time.time > _timeOfResumeSpeed))
        {
            Debug.Log($"speed back to normal");

            GetComponent<OnTrigger>().m_level.currentScrollingSpeed = GetComponent<OnTrigger>().m_level.startingScrollingSpeed;

            IncrementTimer();
        }
    }

    #endregion Unity API

    #region Tools

    private void IncrementTimer()
    {
        _timeOfResumeSpeed = Time.time + m_timeBeforeSlowDown;
        _player._isFreeze = false;
        _player._isInvuln = false;
    }

    #region States

    public void dynamite(PlayerData _player, string _tagName)
    {
        Debug.Log($"i hited a {_tagName} and i get a new boom boom");
        _player.dynamiteCounter += 1;
    }

    public void WaterTear(TheLevelData _level)
    {
        Debug.Log($"WaterTear  : i speed up");

        _level.currentScrollingSpeed = m_speedUpValue;
    }

    public void Balloon(TheLevelData _level)
    {
        Debug.Log($"Balloon : i slow down");

        _level.currentScrollingSpeed = m_speedDownValue;
    }

    public void Invulnerability()
    {
        Debug.Log($"Invulnerability : i took a bread");
        _player._isInvuln = true;
    }

    public void Freezed(PlayerData _player)
    {
        Debug.Log($"Freezed : i took a pill in ibiza");
        _transform.position = _transform.position;

        _player._isFreeze = true;
    }

    public void Background(string _tagName)
    {
        if (_player._isInvuln == false)
        {
            Debug.Log($"outch that hurt it was a {_tagName}");
            _player.dynamiteCounter -= 1;
        }
    }

    #endregion States

    #endregion Tools

    #region Private and Protected Members

    private Transform _transform;
    private float _timeOfResumeSpeed;
    private PlayerData _player;

    #endregion Private and Protected Members
}