using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    public PlayerData player;

    private void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        string _tagName = other.gameObject.tag;

        switch (_tagName)
        {
            case "Dynamite":
                Debug.Log($"i hited a {_tagName}");
                player.dynamiteCounter += 1;
                break;

            case "WaterTear":
                Debug.Log($"WaterTear");
                break;

            default:
                break;
        }

        // Baudruche

        //if (other.gameObject.CompareTag(_tagName))
        //{
        //    Debug.Log($"{other.gameObject.tag}");
        //}
    }
}