using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour
{
    public float speed = 5f;
    public CharacterController controller;
    public Transform player;
    public NavMeshAgent nav;
    float attackCooldown = 2;
    bool attackReady = true;
    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            nav.destination = player.position;
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
            }
            
        }


    }
}
