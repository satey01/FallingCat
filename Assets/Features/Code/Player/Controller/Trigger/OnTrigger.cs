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

        cam.GetComponent<Camera>().enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        _tagName = other.gameObject.tag;

        switch (_tagName)
        {
            case "Dynamite":
                _triggerType.dynamite(m_player, _tagName);
                break;

            case "WaterTear":
                _triggerType.WaterTear(m_level);
                break;

            case "Balloon":
                _triggerType.Balloon(m_level);
                break;

            case "Invulnerability":
                _triggerType.Invulnerability();
                break;

            case "Freezed":
                _triggerType.Freezed(m_player);
                break;

            case "Background":
                _triggerType.Background(_tagName);
                break;

            case "FlyingMouse":

                _triggerType.Background(_tagName);
                break;

            case "EuroDisney":
                _triggerType.EuroDisney(m_level);
                cam.GetComponent<Camera>().enabled = true;
                break;

            default:
                break;
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

    #endregion Private & Protected
}