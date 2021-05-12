using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMusicTrigger : MonoBehaviour
{
    [Header("Put your bonus sound effect here")]
    public List<AudioClip> clipsBonus;

    [Header("Put your malus sound effect here")]
    public List<AudioClip> clipsMalus;

    [Header("Put final explosion sound here to destroy EuroDisney")]
    public AudioClip m_clipExplosion;

    public AudioSource audio;

    #region Unity API

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    #endregion Unity API

    #region Tools

    public void PlayThatClipBonus(bool _bonusMalus)
    {
        if (_bonusMalus)
        {
            int rnd = Random.Range(0, clipsBonus.Count);

            // just be lucky haha
            //Debug.Log($"{rnd} {clipsBonus.Count}");
            audio.PlayOneShot(clipsBonus[rnd]);
        }
        else
        {
            int rnd = Random.Range(0, clipsMalus.Count);

            // just be lucky haha
            //Debug.Log($"{rnd} {clipsMalus.Count}");
            audio.PlayOneShot(clipsMalus[rnd]);
        }
    }

    public void PlayBoom()
    {
        audio.PlayOneShot(m_clipExplosion);
    }

    #endregion Tools
}