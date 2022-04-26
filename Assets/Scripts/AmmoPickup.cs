using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            int ammo = other.gameObject.GetComponent<Gun>().ammo;
            ammo += Random.Range(4, 9);
            if(ammo > 15)
            {
                ammo = 15;
            }
            Destroy(gameObject);
        }
    }
}
