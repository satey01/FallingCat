using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInterfaceMngr : MonoBehaviour
{
    #region Exposed Members

    public PlayerData m_player;
    public Text m_currentDynamite;

    public TheLevelData m_level;
    public Text m_maxDynamite;

    #endregion Exposed Members

    #region Unity API

    private void Start()
    {
        m_player.dynamiteCounter = m_level.maxDynamiteInLevel;

        m_maxDynamite.text = m_level.maxDynamiteInLevel.ToString();
    }

    // Update is called once per frame
    private void Update()
    {
        m_currentDynamite.text = m_player.dynamiteCounter.ToString();
    }

    #endregion Unity API
}