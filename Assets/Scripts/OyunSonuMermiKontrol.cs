using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunSonuMermiKontrol : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Start()
    {

    }

    void Update()
    {


        transform.Translate(Vector3.forward * Time.deltaTime * _speed);


    }


}
