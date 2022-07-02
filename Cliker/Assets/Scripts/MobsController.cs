using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobsController : MonoBehaviour
{
    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine("Run");
        StartCoroutine("Destroy");
    }
    IEnumerable Destroy()
    {
        
        Destroy(gameObject);
        yield return new WaitForSeconds(2f);
    }
    IEnumerator Run()
    {
        while (true)
        {
            float waitTime = Random.Range(0.2f, 0.4f);
            float x = Random.Range(-7.5f, 7.5f);
            float z = Random.Range(-4.5f, 4.5f);
            Vector3 pos = new Vector3(z, 0.75f, x);
            rb.AddForce(pos, ForceMode.Impulse);
            yield return new WaitForSeconds(waitTime);
        }
    }
    // Update is called once per frame
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
