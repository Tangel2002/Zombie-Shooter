using UnityEngine;
using TMPro;
public class Gun : MonoBehaviour
{
    public int ammo = 15;
    public int reserveAmmo = 0;
    public Camera cam;
    public TextMeshProUGUI textMeshPro;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    // Update is called once per frame
    void Update()
    {
        textMeshPro.text = ammo + " / " + reserveAmmo;
        if (Input.GetButtonDown("Fire1"))
        {
            if(ammo > 0 && Time.timeScale == 1)
            {
                Shoot();
            }
        }
    }

    void Shoot()
    {
        RaycastHit victim;
        
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
