using UnityEngine;

public class Hurt : MonoBehaviour
{

    public float health = 4;

    public void Damage()
    {
        health -= 5;
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
