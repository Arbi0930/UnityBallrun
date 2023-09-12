using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstacle;
    void Start()
    {
        InvokeRepeating("Spawner",0.5f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * 50 * Time.deltaTime);
        
    }
    public void Spawner()
    {

        Instantiate(obstacle[Random.Range(0, 2)], new Vector3(Random.Range(-0f, 8f), transform.position.y, transform.position.z), Quaternion.identity);

    }
}
