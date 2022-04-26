using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public float health = 100;

    void Update()
    {
        if(health <= 0)
        {

        }
    }

    public void TakeDamage()
    {
        health -= 5;
    }
}
