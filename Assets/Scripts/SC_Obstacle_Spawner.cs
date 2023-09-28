using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SC_Obstacle_Spawner : MonoBehaviour
{

    public float queueTime = 1.5f, height;
    private float time = 0;
    public GameObject[] obstacles;



    // Update is called once per frame
    void Update()
    {
        if (time>queueTime) {
            var go =Instantiate(obstacles[Random.Range(0,2)]);
            go.transform.position = transform.position + new Vector3(0, Random.Range(-height,height), 0);
            time = 0;
            Destroy(go, 10);
        }
        time += Time.deltaTime;
    }
}
