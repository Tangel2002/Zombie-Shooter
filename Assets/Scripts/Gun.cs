using UnityEngine;

public class Gun : MonoBehaviour
{
    public int ammo = 15;
    public Camera cam;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if(ammo > 0)
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
            Debug.Log(victim.transform.gameObject.tag);
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
