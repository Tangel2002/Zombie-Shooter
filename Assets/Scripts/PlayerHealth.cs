using UnityEngine;
using TMPro;
public class PlayerHealth : MonoBehaviour
{

    public float health = 100;
    public TextMeshProUGUI textMeshPro;
    void Update()
    {
        textMeshPro.text = "Health: " + health.ToString();
        if(health <= 0)
        {

        }
    }

    public void TakeDamage()
    {
        health -= 5;
    }
}
