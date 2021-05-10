using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    #region Unity API

    private void Start()
    {
        _triggerType = GetComponent<TriggerType>();
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

            default:
                break;
        }
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