using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeliScript : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Start()
    {

    }


    void FixedUpdate()
    {
        if (GameController._oyunAktif == true && GameController._finishCizgisi == false)
        {
           // transform.Translate(Vector3.forward * Time.deltaTime * _speed);
        }
        else if (GameController._oyunBitti == true)
        {
            Destroy(gameObject);
        }
        else
        {

        }


    }
}
