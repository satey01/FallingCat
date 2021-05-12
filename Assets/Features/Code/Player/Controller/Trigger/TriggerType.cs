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

    [Header("Flying mouse speed")]
    public float m_flyingSpeed;

    [Header("Put the animator controller of kitty here")]
    public Animator anim;

    [Header("Put the finish line particule system explosion here")]
    public GameObject particleSys;

    #endregion Exposed Members

    #region Unity API

    public void Start()
    {
        _timeOfResumeSpeed = Time.time;
        _transform = GetComponent<Transform>();

        _player = GetComponent<PlayerCtrl>().player;

        particleSys.GetComponent<ParticleSystemRenderer>().enabled = false;
    }

    public void FixTimer(TheLevelData _level)
    {
        if ((Time.time > _timeOfResumeSpeed))
        {
            Debug.Log($"speed back to normal");

            _level.currentScrollingSpeed = _level.startingScrollingSpeed;

            if (_level.justWon == false)
            {
                IncrementTimer();
            }
        }
    }

    #endregion Unity API

    #region Tools

    private void IncrementTimer()
    {
        _timeOfResumeSpeed = Time.time + m_timeBeforeSlowDown;
        _player._isFreeze = false;
        _player._isInvuln = false;

        anim.SetBool("toastIsPickedUp", false);
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

        anim.SetBool("toastIsPickedUp", true);

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

    public void FlyingMouse()
    {
        Debug.Log($"i've catch mickey mouse");
    }

    public void EuroDisney(TheLevelData _level)
    {
        _player._isInvuln = false;
        _player._isFreeze = true;
        _level.justWon = true;

        particleSys.GetComponent<ParticleSystemRenderer>().enabled = true;

        anim.SetBool("toastIsPickedUp", false);
        m_timeBeforeSlowDown = 0.0f;
        _timeOfResumeSpeed = 0.0f;

        Debug.Log($"kitty wakbar ^_^ ");
        anim.SetBool("IsLanding", true);
    }

    #endregion States

    #endregion Tools

    #region Private and Protected Members

    private Transform _transform;
    private float _timeOfResumeSpeed;
    private PlayerData _player;

    #endregion Private and Protected Members
}