using System.Collections;
using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float maxX, maxZ;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(Run());
    }

    IEnumerator Run()
    {
        while (true)
        {
            float waitTime = Random.Range(0.2f, 0.3f);


            var pos = Random.insideUnitCircle;
            pos = new Vector2(pos.x * maxX, pos.y * maxZ);
            rb.AddForce(new Vector3(pos.x, 1f, pos.y), ForceMode.Impulse);
            yield return new WaitForSeconds(waitTime);
        }
    }

}
