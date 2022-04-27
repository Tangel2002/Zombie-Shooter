using UnityEngine;
using TMPro;
public class Gun : MonoBehaviour
{
    public int ammo = 15;
    public int reserveAmmo = 0;
    public Camera cam;
    public TextMeshProUGUI textMeshPro;
    public AudioSource clip;
    public AudioSource shoot;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    // Update is called once per frame
    void Update()
    {
        textMeshPro.text = ammo + " / " + reserveAmmo;

        if (Input.GetKeyDown(KeyCode.R) && ammo != 15 && reserveAmmo != 0)
        {
            Reload();
        }
        if (Input.GetButtonDown("Fire1"))
        {
            if(ammo > 0 && Time.timeScale == 1)
            {
                Shoot();
            }
        }
    }


    void Reload()
    {
        clip.Play();
        if (reserveAmmo < 15)
        {
            while (ammo != 15 && reserveAmmo != 0)
            {
                ammo++;
                reserveAmmo--;
            }
        }
        else
        {
            int temp = 15 - ammo;
            reserveAmmo -= temp;
            ammo = 15;
        }
    }

    void Shoot()
    {
        RaycastHit victim;
        shoot.Play();
        ammo--;
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out victim))
        {
            if (victim.transform.gameObject.tag == "Shootable")
            {
                Hurt enemy = victim.transform.gameObject.GetComponent<Hurt>();
                if(enemy != null)
                {
                    enemy.Damage();
                }
            }
        }
    }
}
