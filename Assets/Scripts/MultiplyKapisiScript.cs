using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiplyKapisiScript : MonoBehaviour
{
    [SerializeField] Text multiplyText;
    [SerializeField] int multiplyDegeri;
    [SerializeField] GameObject CollectAskeriPrefab;


    // Start is called before the first frame update
    void Start()
    {
        multiplyText.text = "+" + multiplyDegeri.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            for (int i = 0; i < multiplyDegeri; i++)
            {

                GameObject tempAsker = Instantiate(CollectAskeriPrefab, new Vector3(100, 100, 100), Quaternion.identity);
                tempAsker.transform.parent = other.gameObject.transform.GetChild(8).transform;
                tempAsker.transform.localPosition = new Vector3(0, 1, -3);
                tempAsker.transform.parent = GameObject.Find("StackAskerParent").transform;

                tempAsker.GetComponent<BoxCollider>().isTrigger = false;
                tempAsker.GetComponent<CollectableAskerScript>().player = other.gameObject.transform.GetChild(4).gameObject;
                tempAsker.GetComponent<CollectableAskerScript>().collectedAsker = true;
                tempAsker.GetComponent<Animator>().SetBool("Idle", false);
                tempAsker.GetComponent<Animator>().SetBool("Run", true);
                Debug.Log(tempAsker.GetComponent<CollectableAskerScript>().player.name);

                PlayerController._askeriGuc += 1;
            }

        }
    }



}
