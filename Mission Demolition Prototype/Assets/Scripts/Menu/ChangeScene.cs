using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void StartButton_onClick(int id)
    {
        SceneManager.LoadSceneAsync(id);
    }

    public void ExitButton_onClick()
    {
        Application.Quit();
    }
}
