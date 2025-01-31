using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FruitManager : MonoBehaviour
{
    public Text text;
    int Total;

    // Start is called before the first frame update
    void Start()
    {
        Total = gameObject.transform.childCount;
        FruitCount();
    }

    // Update is called once per frame
    void Update()
    {
        FruitCount();
    }

    void FruitCount()
    {
        //CUENTA LAS FRUTAS EN PANTALLA
        int count = gameObject.transform.childCount;
        //ASIGNA EL VALOR EN EL TEXTO
        text.text = "Frutas recolectadas: " + (Total - count) + " / " + Total;
        if (count == 0)
        {
            text.text = "YAIIII!!!";
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 );  
        }
    }
}
