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

    private bool _öldü;
    // Start is called before the first frame update
    void Start()
    {
        stackAskerAnim = transform.GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        agent.enabled = false;
        agent.enabled = true;
        player = GameObject.FindGameObjectWithTag("Takip1");


        _öldü = false;
        //stackAskerAnim.SetBool("Idle", false);
        //stackAskerAnim.SetBool("Run", true);
        //collectedAsker = false;
        //  player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(collectedAsker);
        if (collectedAsker == true && GameController._finishCizgisi == false && _öldü == false)
        {
            Debug.Log("girdim : " + player.name);
            player = GameObject.FindGameObjectWithTag("Takip1");
            agent.SetDestination(player.transform.position);
        }

        if (GameController._oyunBitti == true)
        {
            Destroy(gameObject);
        }
        else
        {

        }

        if (GameController._finishCizgisi == true)
        {
            agent.enabled = false;
            stackAskerAnim.SetBool("Run", false);
            stackAskerAnim.SetBool("Attack", true);

            transform.rotation = Quaternion.Euler(0, 60, 0);
        }
        else
        {

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && collectedAsker == false)
        {
            Debug.Log("playera dokundu calısıyor.");
            gameObject.GetComponent<BoxCollider>().isTrigger = false;
            gameObject.transform.parent = GameObject.FindGameObjectWithTag("Takip1").transform;
            gameObject.transform.localPosition = new Vector3(0, 0, 0);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            gameObject.transform.parent = GameObject.Find("StackAskerParent").transform;
            player = other.gameObject.transform.GetChild(4).gameObject;


            collectedAsker = true;
            stackAskerAnim.SetBool("Idle", false);
            stackAskerAnim.SetBool("Run", true);

            PlayerController._askeriGuc += 1;

        }
        else if (other.tag == "Obstacles" || other.tag == "Missile")
        {
            Debug.Log("obstaclea dokundu calısıyor.");

            if (_öldü == false)
            {
                gameObject.transform.parent = null;
                collectedAsker = false;
                stackAskerAnim.SetBool("Run", false);
                stackAskerAnim.SetBool("Death", true);
                Destroy(gameObject, 2f);

                PlayerController._askeriGuc -= 1;

                _öldü = true;
            }
            else
            {

            }

        }
        else
        {

        }
    }
}
