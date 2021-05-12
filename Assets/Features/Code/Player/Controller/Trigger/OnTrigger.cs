using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    public Camera cam;

    #region Unity API

    private void Start()
    {
        _triggerType = GetComponent<TriggerType>();
        _triggerMusic = GetComponent<OnMusicTrigger>();

        cam.GetComponent<Camera>().enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        _tagName = other.gameObject.tag;

        switch (_tagName)
        {
            case "Dynamite":
                _triggerType.Dynamite(m_player, _tagName);
                _triggerMusic.PlayThatClipBonus(true);

                break;

            case "WaterTear":
                _triggerType.WaterTear(m_level);
                _triggerMusic.PlayThatClipBonus(false);

                break;

            case "Balloon":
                _triggerType.Balloon(m_level);
                _triggerMusic.PlayThatClipBonus(true);

                break;

            case "Background":
                _triggerType.Background(_tagName);
                if (m_player._isInvuln == false)
                {
                    _triggerMusic.PlayThatClipBonus(false);
                }

                break;

            case "Invulnerability":
                _triggerType.Invulnerability();
                _triggerMusic.PlayThatClipBonus(true);
                break;

            case "FlyingMouse":
                _triggerType.Background(_tagName);
                _triggerMusic.PlayThatClipBonus(false);

                break;

            case "Freezed":
                _triggerType.Freezed(m_player);
                _triggerMusic.PlayThatClipBonus(false);
                break;

            case "EuroDisney":
                _triggerType.EuroDisney(m_level);
                cam.GetComponent<Camera>().enabled = true;

                _triggerMusic.PlayBoom();
                break;

            default:
                break;
        }
        // lol logic ? !
        if (!other.CompareTag("Background") && !other.CompareTag("EuroDisney"))
        {
            Destroy(other.gameObject);
        }
        else if (m_player._isInvuln == true)
        {
            Destroy(other.gameObject);
        }
    }

    private void FixedUpdate()
    {
        // win cond
        _triggerType.FixTimer(m_level);
    }

    #endregion Unity API

    #region Private & Protected

    [HideInInspector]
    public PlayerData m_player;

    public TheLevelData m_level;

    private string _tagName;
    private TriggerType _triggerType;
    private OnMusicTrigger _triggerMusic;

    #endregion Private & Protected
}