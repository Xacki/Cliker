using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static int score = 0;

    private void OnMouseDown()
    {
        score++;
        Destroy(gameObject);
        
        
    }
}
