using System;
using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public TextMeshProUGUI nameInput;
    public TextMeshProUGUI highScoreText;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.LoadScore();

        if (GameManager.Instance.highScore > 0)
        {
            highScoreText.text = $"{GameManager.Instance.highScore}";
        }
        else
        {
            highScoreText.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void NameChange()
    {
        GameManager.Instance.thisName = nameInput.text;
    }
}
