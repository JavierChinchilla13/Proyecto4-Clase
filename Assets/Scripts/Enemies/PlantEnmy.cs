using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantEnmy : MonoBehaviour
{
    public float waitedTime;
    public float waitTimeToAttack = 3;
    public Animator Animator;
    public GameObject bulletPrefabs;
    public Transform launchSpawnPoint;

    void Start()
    {
        waitedTime = waitTimeToAttack;
    }

    void Update()
    {
        if(waitedTime <= 0)
        {
            waitedTime = waitTimeToAttack;
            Animator.Play("Attack");
            Invoke("LaunchBullet", 0.5f);
        }
        else
        {
            waitedTime -= Time.deltaTime;
        }
    }

    public void LaunchBullet()
    {
        GameObject newBullet;
        newBullet = Instantiate(bulletPrefabs, launchSpawnPoint.position, launchSpawnPoint.rotation);
    }
}
