using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void LoadScene(string scene)
    {
        if (scene == "Quit")
        {
            Application.Quit();
        }
        else
            SceneManager.LoadScene(scene);
    }
}
