using UnityEngine;

public class AmmoPickup : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Gun ammo = other.gameObject.GetComponent<Gun>();
            ammo.reserveAmmo += Random.Range(4, 6);

            Destroy(gameObject);
        }
    }
}
