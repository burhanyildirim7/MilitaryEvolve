using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    private GameObject Player;

    private GameObject _oyunSonuBelirlemeObjesi;

    Vector3 aradakiFark;


    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        _oyunSonuBelirlemeObjesi = GameObject.FindGameObjectWithTag("OyunSonuBelirlemeObjesi");
        aradakiFark = transform.position - Player.transform.position;
    }


    void Update()
    {

        if (GameController._finishCizgisi == true)
        {
            //transform.position = Vector3.Lerp(transform.position, new Vector3(0, 29, Player.transform.position.z - 11.2f), Time.deltaTime * 2f);
            transform.position = Vector3.Lerp(transform.position, new Vector3(0, Player.transform.position.y + aradakiFark.y, _oyunSonuBelirlemeObjesi.transform.position.z + aradakiFark.z), Time.deltaTime * 5f);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(Player.transform.position.x, Player.transform.position.y + aradakiFark.y, Player.transform.position.z + aradakiFark.z), Time.deltaTime * 5f);
            // transform.position = Vector3.Lerp(transform.position, new Vector3(5, Player.transform.position.y + aradakiFark.y, Player.transform.position.z + aradakiFark.z), Time.deltaTime * 3f);
            // transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(30, -25, transform.rotation.z), 15f * Time.deltaTime);
        }
    }



    public void CameraReset()
    {
        transform.position = new Vector3(0, 15, -20);
        //transform.rotation = Quaternion.Euler(30, 0, 0);
        aradakiFark = transform.position - Player.transform.position;
    }
}
