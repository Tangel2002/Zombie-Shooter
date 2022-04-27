using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kills : MonoBehaviour
{
    public int kills = 0;
    public TextMeshProUGUI textMeshProUGUI;



    void Update()
    {
        textMeshProUGUI.text = "Zombie Kills: " + kills;
        if(kills >= 100)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
