using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform Player;
    private float turn = 0.05f;
    private float rand = 0f;
    private float timer = 0f;
    
    void Start()
    {
        rand = Random.Range(0.5f, 3.0f);
    }
   
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= rand)
        {   
            timer = 0f;
            rand = Random.Range(0.5f, 3.0f);
            GameObject bullet = Instantiate(BulletPrefab, transform);
            bullet.transform.LookAt(Player);

        }
        
    }
}
