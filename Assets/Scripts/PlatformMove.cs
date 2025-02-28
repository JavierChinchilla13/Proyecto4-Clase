using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public float speed = 1;
    private float waitTime;
    public float startWaitTime = 2;
    private int i = 0;

    public Transform[] moveSpots;
    // Start is called before the first frame update
    void Start()
    {
        waitTime = startWaitTime;
    }

    // Update is called once per frame
    void Update()
    {
        //MUEVE EL OBJETO DE UN PUNTO A OTRO
        transform.position = Vector2.MoveTowards(transform.position, moveSpots[i].transform.position, speed * Time.deltaTime);

        //VALIDA SI LLEGO AL PUNTO
        if (Vector2.Distance(transform.position, moveSpots[i].transform.position) < 0.1f)
        {
            //VERIFICA SI YA REALIZO EL TIEMPO DE ESPERA
            if (waitTime <= 0)
            {
                //CAMBIA EL CONTADOR i AL SIGUENTE PUNTO
                if (moveSpots[i] != moveSpots[moveSpots.Length - 1])
                {
                    i++;
                }
                else
                {
                    i = 0;
                }
                waitTime = startWaitTime;
            }
            else
            {
                //CUENTA EL TIEMPO DE ESPERA
                waitTime -= Time.deltaTime;
            }


        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.collider.transform.SetParent(transform);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.collider.transform.SetParent(null);
    }
}
