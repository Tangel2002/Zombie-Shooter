using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    //public AudioSource aud;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Gun ammo = other.gameObject.GetComponent<Gun>();
            ammo.reserveAmmo += Random.Range(5, 9);
            //aud.Play();
            Destroy(gameObject);
        }
    }
}
