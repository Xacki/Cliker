using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private int score = 0;
    [SerializeField] private Camera camera;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider != null)
                {
                    var move = hit.collider.GetComponent<MoveObjects>();
                    if (move)
                    {
                        ScoreAdd();
                        Destroy(hit.collider.transform.gameObject);
                    }
                }
            }
        }
    }


    public void UpdateText()
    {
        scoreText.text = score.ToString();
    }

    public void ScoreAdd()
    {
        score++;
        UpdateText();
    }
}
