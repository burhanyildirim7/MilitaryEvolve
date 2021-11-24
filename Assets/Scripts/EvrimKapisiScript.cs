using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvrimKapisiScript : MonoBehaviour
{
    [SerializeField] List<GameObject> secimPanelleri = new List<GameObject>();
    [SerializeField] List<GameObject> savasAraclari = new List<GameObject>();

    [SerializeField] bool tank, zirhli, heli;
    // Start is called before the first frame update
    void Start()
    {
        if (tank)
        {
            secimPanelleri[0].gameObject.SetActive(true);
            secimPanelleri[1].gameObject.SetActive(false);
            secimPanelleri[2].gameObject.SetActive(false);
        }
        else if (zirhli)
        {
            secimPanelleri[0].gameObject.SetActive(false);
            secimPanelleri[1].gameObject.SetActive(true);
            secimPanelleri[2].gameObject.SetActive(false);
        }
        else if (heli)
        {
            secimPanelleri[0].gameObject.SetActive(false);
            secimPanelleri[1].gameObject.SetActive(false);
            secimPanelleri[2].gameObject.SetActive(true);
        }
        else
        {

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (tank)
            {
                if (PlayerController.zirhliSol == true && PlayerController.zirhliSag == true)
                {
                    if (PlayerController.tankSag == false || PlayerController.tankSol == false)
                    {
                        Destroy(GameObject.Find("StackZirhliParent").transform.GetChild(0));
                        Destroy(GameObject.Find("StackZirhliParent").transform.GetChild(1));
                        GameObject tempObject = Instantiate(savasAraclari[0], new Vector3(100, 100, 100), Quaternion.identity);
                        tempObject.transform.parent = other.gameObject.transform.parent.transform.GetChild(2).transform;
                        if (PlayerController.tankSag == false)
                        {
                            tempObject.transform.localPosition = new Vector3(4.5f, 1, 0);
                            tempObject.transform.parent = null;
                            PlayerController.tankSag = true;
                        }
                        else
                        {
                            tempObject.transform.localPosition = new Vector3(-4.5f, 1, 0);
                            tempObject.transform.parent = null;
                            PlayerController.tankSol = true;
                        }
                    }
                }
            }
            else
            {
                if (GameObject.Find("StackAskerParent").transform.childCount > 5)
                {
                    if (zirhli)
                    {
                        if (PlayerController.zirhliSag == false)
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                Destroy(GameObject.Find("StackAskerParent").gameObject.transform.GetChild(GameObject.Find("StackAskerParent").transform.childCount - 1));
                            }
                            GameObject tempObject = Instantiate(savasAraclari[1], new Vector3(100, 100, 100), Quaternion.identity);
                            tempObject.transform.parent = other.gameObject.transform.GetChild(8).transform;
                            tempObject.transform.localPosition = new Vector3(1.25f, 1, -6);
                            tempObject.transform.parent = GameObject.Find("StackZirhliParent").transform;
                            tempObject.transform.parent = null;
                            PlayerController.zirhliSag = true;
                        }
                        else if (PlayerController.zirhliSol == false)
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                Destroy(GameObject.Find("StackAskerParent").gameObject.transform.GetChild(GameObject.Find("StackAskerParent").transform.childCount - 1));
                            }
                            GameObject tempObject = Instantiate(savasAraclari[1], new Vector3(100, 100, 100), Quaternion.identity);
                            tempObject.transform.parent = other.gameObject.transform.GetChild(8).transform;
                            tempObject.transform.localPosition = new Vector3(-1.25f, 1, -6);
                            tempObject.transform.parent = GameObject.Find("StackZirhliParent").transform;
                            tempObject.transform.parent = null;
                            PlayerController.zirhliSol = true;
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        if (PlayerController.heliSag == false)
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                Destroy(GameObject.Find("StackAskerParent").gameObject.transform.GetChild(GameObject.Find("StackAskerParent").transform.childCount - 1));
                            }
                            GameObject tempObject = Instantiate(savasAraclari[1], new Vector3(100, 100, 100), Quaternion.identity);
                            tempObject.transform.parent = other.gameObject.transform.parent.transform.GetChild(2).transform;
                            tempObject.transform.localPosition = new Vector3(4, 5, 1.5f);
                            tempObject.transform.parent = null;
                            PlayerController.heliSag = true;
                        }
                        else if (PlayerController.heliSol == false)
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                Destroy(GameObject.Find("StackAskerParent").gameObject.transform.GetChild(GameObject.Find("StackAskerParent").transform.childCount - 1));
                            }
                            GameObject tempObject = Instantiate(savasAraclari[1], new Vector3(100, 100, 100), Quaternion.identity);
                            tempObject.transform.parent = other.gameObject.transform.parent.transform.GetChild(2).transform;
                            tempObject.transform.localPosition = new Vector3(-4, 5, 1.5f);
                            tempObject.transform.parent = null;
                            PlayerController.heliSag = true;

                        }
                        else
                        {

                        }
                    }
                }
            }
        }
    }
}
