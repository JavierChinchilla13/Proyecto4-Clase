using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static PlayerSelect;

public class ChangeSkin : MonoBehaviour
{
   

    public GameObject skinPanel;
    public bool inDoor = false;
    public GameObject player;

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            skinPanel.gameObject.SetActive(true);
            inDoor = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            skinPanel.gameObject.SetActive(false);
            inDoor = false;
        }
    }

    public void SetPlayerFrog()
    {
        PlayerPrefs.SetString("PlayerSelected", "Frog");
        ResetPlayerSkin();
    }

    public void SetPlayerMask()
    {
        PlayerPrefs.SetString("PlayerSelected", "Mask");
        ResetPlayerSkin();
    }

    public void SetPlayerVirtual()
    {
        PlayerPrefs.SetString("PlayerSelected", "Virtual");
        ResetPlayerSkin();
    }

    public void SetPlayerPink()
    {
        PlayerPrefs.SetString("PlayerSelected", "Pink");
        ResetPlayerSkin();
    }

    void ResetPlayerSkin()
    {
        skinPanel.gameObject.SetActive(false);
        player.GetComponent<PlayerSelect>().ChangePlayerInMenu();
    }
}
