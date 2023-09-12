using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            StartCoroutine("MoveLevel");
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerable MoveLevel()
    {
        yield return new WaitForSeconds(2f);
        gameObject.transform.parent.position = new Vector3(0,0,gameObject.transform.position.z + 40); 
    }
}
