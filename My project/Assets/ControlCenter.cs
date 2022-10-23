using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlCenter : MonoBehaviour
{
    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadScene(int scaneIndex)
    {
        SceneManager.LoadScene(scaneIndex);

        Debug.Log("Load Scene " + scaneIndex);
    }

    public void QuitGame()
    {
        Application.Quit();

    }

}
