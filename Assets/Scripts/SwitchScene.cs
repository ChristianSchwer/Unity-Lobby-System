using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    #region Private Fields

    [SerializeField]
    private GameObject backOptions;

    #endregion

    #region Public Methods

    public void NextScene(string Scene)
    {
        if (Scene == "LobbyScene")
        {
            SceneManager.LoadScene(Scene);
        }
        if (Scene == "HomeScene")
        {
            SceneManager.LoadScene(Scene);
        }
    }

    public void SingleplayerScene()
    {
        SceneManager.LoadScene("SingleplayerScene");
    }

    public void BackButton()
    {
        if (backOptions.activeSelf == true)
        {
            backOptions.SetActive(false);
        }
        else
        {
            backOptions.SetActive(true);
        }
    }

    #endregion
}
