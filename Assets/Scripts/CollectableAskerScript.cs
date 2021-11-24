using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.AI;

public class CollectableAskerScript : MonoBehaviour
{
    Animator stackAskerAnim;
    public bool collectedAsker;
    NavMeshAgent agent;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        stackAskerAnim = transform.GetComponent<Animator>();
        collectedAsker = false;
        agent = GetComponent<NavMeshAgent>();
        //  player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (collectedAsker == true)
        { Debug.Log("girdim : " +player.name);
            agent.SetDestination(player.transform.position);
            gameObject.GetComponent<NavMeshAgent>().enabled = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"&& collectedAsker==false)
        {
            Debug.Log("playera dokundu calısıyor.");
            gameObject.GetComponent<BoxCollider>().isTrigger = false;
            gameObject.transform.parent = other.gameObject.transform.GetChild(8).transform;
            gameObject.transform.localPosition = new Vector3(0,0,0);
            gameObject.transform.parent = GameObject.Find("StackAskerParent").transform;
            player = other.gameObject.transform.GetChild(4).gameObject;

            collectedAsker = true;
            stackAskerAnim.SetBool("Run", true);
            stackAskerAnim.SetBool("Idle", false);
        }
        else if (other.tag == "Obstacles" || other.tag == "Missile")
        {
            Debug.Log("obstaclea dokundu calısıyor.");
            gameObject.transform.parent = null;
            collectedAsker = false;
            stackAskerAnim.SetBool("Run", false);
            stackAskerAnim.SetBool("Idle", true);
            Destroy(gameObject, 2f);
        }
        else
        {

        }
    }
}
