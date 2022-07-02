using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnObjects : MonoBehaviour
{
    public Object monstr;
    public int maxMonstrCount;
    void Start()
    {
        StartCoroutine("spawnMonstr");
    }
    IEnumerator spawnMonstr()
    {
        while (true)
        {
            if (GameObject.FindGameObjectsWithTag("Monstr").Length>= maxMonstrCount)
            {
                SceneManager.LoadScene("Menu");
                break;
            }
            float waitTime = Random.Range(2f, 3f);
            float x = Random.Range(-4.75f, 4.75f);
            float z = Random.Range(-10.25f, 10.25f);
            Vector3 pos = new Vector3(x, 1f, z);
            yield return new WaitForSeconds(waitTime);
            Instantiate(monstr, pos, Quaternion.identity);
        }

    }
}
