using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenButtonToLoadOtherScene : MonoBehaviour
{
    [SerializeField] private GameObject buttonSecondScene = null;

    public void OnMouseDown()
    {
        buttonSecondScene.SetActive(true);     
    }

    public void LoadToSecondScene()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadToFirstScene()
    {
        SceneManager.LoadScene(0);
    }
}
