using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject prefab1;
    public GameObject prefab2;

    float cooldown = 3;
    int max = 0;

    void Update()
    {
        cooldown -= Time.deltaTime;
        if(cooldown <= 0 && max != 100)
        {
            int pick = Random.Range(1, 3);
            if(pick == 1)
            {
                GameObject temp = Instantiate(prefab1, gameObject.transform.position, gameObject.transform.rotation);
                temp.GetComponent<Hurt>().health += max / 5;
            }
            if(pick == 2)
            {
                GameObject temp = Instantiate(prefab2, gameObject.transform.position, gameObject.transform.rotation);
                temp.GetComponent<Hurt>().health += max / 10;
            }
            max++;
            cooldown = 3;
            TP();
        }
    }

    void TP()
    {
        gameObject.transform.position = new Vector3(Random.Range(-25, 81), 3, Random.Range(-25, 81));
    }
}
