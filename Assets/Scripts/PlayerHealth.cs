using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{

    public float health = 100;
    public TextMeshProUGUI textMeshPro;
    void Update()
    {
        textMeshPro.text = "Health: " + health.ToString();
        if(health <= 0)
        {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("Lose");
        }
    }

    public void TakeDamage()
    {
        health -= 5;
    }
}
