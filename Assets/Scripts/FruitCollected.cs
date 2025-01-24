using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCollected : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //DESABILITA LA IMAGE DE LA FRUTA
            GetComponent<SpriteRenderer>().enabled = false;
            //OBTIENE EL OBJECTO QUE ESTA DENTRO DE LA FRUTA Y LO ACTIVA
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            //ELIMINA LA FRUTA MEDIOSEGUNDO DESPUES
            Destroy(gameObject, 0.5f);
        }
    }
  
}
