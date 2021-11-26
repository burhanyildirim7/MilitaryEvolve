using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.AI;
using UnityEngine.UI;

public class ZirhliScript : MonoBehaviour
{
    [SerializeField] private Slider _healtBar;
    NavMeshAgent agent;
    public GameObject player;

    private float _health;
    private bool _death;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.enabled = false;
        agent.enabled = true;
        player = GameObject.FindGameObjectWithTag("Takip2");
        _health = 100;
        _healtBar.value = _health;
        _death = false;
    }


    void Update()
    {
        if (_death == false && GameController._finishCizgisi == false)
        {
            agent.SetDestination(player.transform.position);
        }


        if (_death == false && GameController._oyunBitti == true)
        {
            Destroy(gameObject);
            _death = true;
        }
        else
        {

        }

        if (GameController._finishCizgisi == true)
        {
            agent.enabled = false;

            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {

        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacles" || other.tag == "Missile")
        {
            Debug.Log("obstaclea dokundu calısıyor.");

            _health -= 20;

            _healtBar.value = _health;

            if (_health < 0)
            {
                _death = true;
                gameObject.transform.parent = null;
                agent.enabled = false;

                if (PlayerController.tankSag == true && PlayerController.tankSol == true)
                {
                    PlayerController.tankSag = false;
                }
                else if (PlayerController.tankSag == true && PlayerController.tankSol == false)
                {
                    PlayerController.tankSag = false;
                }
                else if (PlayerController.tankSag == false && PlayerController.tankSol == true)
                {
                    PlayerController.tankSol = false;
                }
                else
                {

                }

                Destroy(gameObject, 2f);

                PlayerController._askeriGuc -= 5;
            }


        }
    }
}
