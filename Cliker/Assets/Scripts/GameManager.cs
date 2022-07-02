using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject monster;
    IEnumerator spawnMonstr()
    {
        while (true)
        {

                float waitTime = Random.Range(0f, 1f);
                float x = Random.Range(-4.75f, 4.75f);
                float z = Random.Range(-10.25f, 10.25f);
                Vector3 pos = new Vector3(x, 0.75f, z);
                yield return new WaitForSeconds(waitTime);
                Instantiate(monster, pos, Quaternion.identity);
            
            
        }
            
    }

    public void FixedUpdate()
    {
       
    }
    public void Start()
    {
        StartCoroutine("spawnMonstr");
    }

}
