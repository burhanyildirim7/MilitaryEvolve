using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakipObjesiScript : MonoBehaviour
{

    [SerializeField] private bool _takip1;
    [SerializeField] private bool _takip2;
    [SerializeField] private bool _takip3;


    private GameObject _player;

    void Start()
    {

    }


    void Update()
    {
        _player = GameObject.FindGameObjectWithTag("Player");

        if (_takip1)
        {
            transform.position = new Vector3(_player.transform.position.x, transform.position.y, _player.transform.position.z - 2.5f);
        }
        else if (_takip2)
        {
            transform.position = new Vector3(_player.transform.position.x, transform.position.y, _player.transform.position.z - 5f);
        }
        else if (_takip3)
        {
            transform.position = new Vector3(_player.transform.position.x, transform.position.y, _player.transform.position.z - 7.5f);
        }
        else
        {

        }

    }
}
