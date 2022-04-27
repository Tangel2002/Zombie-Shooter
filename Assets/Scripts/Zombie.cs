using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour
{
    public CharacterController controller;
    GameObject player;
    public NavMeshAgent nav;
    float attackCooldown = 2;
    bool attackReady = true;
    PlayerHealth playersHealth;
    // Update is called once per frame
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playersHealth = player.GetComponent<PlayerHealth>();
    }
    void Update()
    {
        if (controller.isGrounded == false)
        {
            controller.Move(Vector3.down * Time.deltaTime * 5);
        }
        
        if(player != null)
        {
            nav.destination = player.transform.position;
        }


        if (!attackReady)
        {
            attackCooldown -= 1 * Time.deltaTime;
            if(attackCooldown <= 0)
            {
                attackReady = true;
                attackCooldown = 2;
            }
        }

        RaycastHit hit;
        if(Physics.Raycast(gameObject.transform.position, gameObject.transform.forward, out hit, 1.7f))
        {
            if (hit.transform.gameObject.name == "Player" && attackCooldown == 2)
            {
                attackReady = false;
                playersHealth.TakeDamage();
            }
            
        }


    }
}
