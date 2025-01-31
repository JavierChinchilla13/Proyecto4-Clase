using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("checkPointScene") == SceneManager.GetActiveScene().buildIndex)
        {
            if(PlayerPrefs.GetFloat("checkPointX") != 0 && PlayerPrefs.GetFloat("checkPointY") != 0)
            {
                transform.position = new Vector2(PlayerPrefs.GetFloat("checkPointX"),
                    PlayerPrefs.GetFloat("checkPointY"));
            }
        }
        
    }

    public void ReachedCheckPoint(float x, float y, int scene)
    {
        PlayerPrefs.SetFloat("checkPointX",x);
        PlayerPrefs.SetFloat("checkPointY", y);
        PlayerPrefs.SetInt("checkPointScene", scene);
    }

    internal void ReachedCheckPoint(float x, float y, object builIndex)
    {
        throw new NotImplementedException();
    }
}
