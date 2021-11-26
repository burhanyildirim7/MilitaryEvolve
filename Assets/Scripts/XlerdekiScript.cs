using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XlerdekiScript : MonoBehaviour
{

    [SerializeField] private GameObject _patlamaEfekti;
    [SerializeField] private Animator _birinciAsker;
    [SerializeField] private Animator _ikinciAsker;
    [SerializeField] private GameObject _confettiPaketi;

    private PlayerController _playerController;
    private bool _objeDegdimi;

    private UIController _uiController;

    private int _XDegeri;

    void Start()
    {
        _objeDegdimi = false;
        _patlamaEfekti.SetActive(false);
        _confettiPaketi.SetActive(false);
        _playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        _uiController = GameObject.FindGameObjectWithTag("UIController").GetComponent<UIController>();
    }


    public void OyunSonuElmas(int deger)
    {
        int oyunSonuElmasDeger;

        oyunSonuElmasDeger = deger * PlayerController._askeriGuc;

        _uiController.LevelSonuElmasSayisi(oyunSonuElmasDeger);
    }

    public void ConfettiPatlat()
    {
        _confettiPaketi.SetActive(true);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            if (_objeDegdimi == false)
            {
                Destroy(other.gameObject);
            }
            else
            {

            }

        }
        else if (other.gameObject.tag == "OyunSonuBelirlemeObjesi")
        {
            _objeDegdimi = true;
            _patlamaEfekti.SetActive(true);
            _birinciAsker.SetBool("Death", true);
            _ikinciAsker.SetBool("Death", true);
        }

    }
}
