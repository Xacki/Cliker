using System.Collections;
using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine("Run");
    }

    IEnumerator Run()
    {
        while (true)
        {
            
            float waitTime = Random.Range(0.2f, 0.3f);
            float x = Random.Range(-7.5f, 7.5f);
            float z = Random.Range(-4.5f, 4.5f);
            Vector3 pos = new Vector3(z, 1f, x);
            rb.AddForce(pos, ForceMode.Impulse);
            yield return new WaitForSeconds(waitTime);
        }
    }

}
