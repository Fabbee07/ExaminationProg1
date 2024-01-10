using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneName; // Name of the scene to load
    public string sceneName2;
    public string sceneName3;
    // Method to load a new scene
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void LoadScene1()
    {
        SceneManager.LoadScene(sceneName2);
    }
    public void LoadScene2()
    {
        SceneManager.LoadScene(sceneName3);
    }
}
