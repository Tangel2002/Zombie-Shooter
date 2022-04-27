using UnityEngine;

public class Hurt : MonoBehaviour
{
    public float health = 4;
    public GameObject ammo;
    GameObject manager;
    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("kills");
    }
    public void Damage()
    {
        health -= 5;
        if(health <= 0)
        {
            Instantiate(ammo, gameObject.transform.position, gameObject.transform.rotation);
            manager.GetComponent<Kills>().kills++;
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
