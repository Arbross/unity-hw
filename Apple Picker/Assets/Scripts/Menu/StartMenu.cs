using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
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
