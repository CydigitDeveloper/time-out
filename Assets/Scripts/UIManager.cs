using UnityEngine;
using UnityEngine.SceneManagement; // Namespace for scene management

public class UIManager : MonoBehaviour
{
    public void StartButton(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}