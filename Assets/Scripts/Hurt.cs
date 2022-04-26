using UnityEngine;

public class Hurt : MonoBehaviour
{

    public float health = 4;
    public GameObject ammo;
    public void Damage()
    {
        health -= 5;
        if(health <= 0)
        {
            Instantiate(ammo, gameObject.transform.position, gameObject.transform.rotation);
            Kill();
        }
    }

    void Kill()
    {
        Destroy(gameObject);
    }
}
