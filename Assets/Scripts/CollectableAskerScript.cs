using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.AI;

public class CollectableAskerScript : MonoBehaviour
{
    Animator stackAskerAnim;
    private bool collectedAsker;
    NavMeshAgent agent;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        stackAskerAnim = transform.GetComponent<Animator>();
        collectedAsker = false;
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (collectedAsker == true)
        {
            agent.SetDestination(player.transform.position);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
            Debug.Log("playera dokundu calısıyor.");
            if (other.gameObject.transform.parent.transform.GetChild(2).gameObject.transform.childCount<5)
            {
                gameObject.transform.parent = other.gameObject.transform.parent.transform.GetChild(2).transform;
            }
            else
            {
                gameObject.transform.parent = other.gameObject.transform.parent.transform.GetChild(3).transform;
            }
            collectedAsker = true;
            stackAskerAnim.SetBool("Run",true);
            stackAskerAnim.SetBool("Idle", false);
        }
        else if (other.tag == "Obstacles" || other.tag == "Missile")
        {
            Debug.Log("obstaclea dokundu calısıyor.");
            gameObject.transform.parent = null;
            collectedAsker = false;
            stackAskerAnim.SetBool("Run", false);
            stackAskerAnim.SetBool("Idle", true);
            Destroy(gameObject,2f);
        }
        else
        {
            
        }
    }
}
