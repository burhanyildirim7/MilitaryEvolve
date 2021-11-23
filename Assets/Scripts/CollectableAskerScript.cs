using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class CollectableAskerScript : MonoBehaviour
{
    Animator stackAskerAnim;
    // Start is called before the first frame update
    void Start()
    {
        stackAskerAnim = transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="KarakterPaketi")
        {
            Debug.Log("playera dokundu calısıyor.");
            gameObject.transform.parent = other.gameObject.transform.GetChild(2).transform;
            stackAskerAnim.SetBool("Run",true);
            stackAskerAnim.SetBool("Idle", false);
        }
        else if (other.tag == "Obstacles")
        {
            gameObject.transform.parent = null;
            stackAskerAnim.SetBool("Run", false);
            stackAskerAnim.SetBool("Idle", true);
            Destroy(gameObject,2f);
        }
        else
        {
            
        }
    }
}
