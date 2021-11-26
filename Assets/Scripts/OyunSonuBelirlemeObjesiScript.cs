using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunSonuBelirlemeObjesiScript : MonoBehaviour
{
    [SerializeField] private float _speed;

    private int _XDegeri;

    private PlayerController _playerController;

    void Start()
    {
        _XDegeri = 0;
        _playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController._finishCizgisi == true && GameController._oyunBitti == false)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);
        }
        else
        {

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "X1")
        {
            if (PlayerController._askeriGuc <= 5)
            {
                _XDegeri = 1;
                other.gameObject.GetComponent<XlerdekiScript>().OyunSonuElmas(_XDegeri);
                other.gameObject.GetComponent<XlerdekiScript>().ConfettiPatlat();
                GameController._oyunBitti = true;
                GameController._oyunAktif = false;
                _playerController.WinScreenAc(_XDegeri);
                _XDegeri = 0;
            }
            else
            {

            }
        }
        else if (other.gameObject.tag == "X2")
        {
            if (PlayerController._askeriGuc <= 10)
            {
                _XDegeri = 2;
                other.gameObject.GetComponent<XlerdekiScript>().OyunSonuElmas(_XDegeri);
                other.gameObject.GetComponent<XlerdekiScript>().ConfettiPatlat();
                GameController._oyunBitti = true;
                GameController._oyunAktif = false;
                _playerController.WinScreenAc(_XDegeri);
                _XDegeri = 0;
            }
            else
            {

            }
        }
        else if (other.gameObject.tag == "X3")
        {
            if (PlayerController._askeriGuc <= 15)
            {
                _XDegeri = 3;
                other.gameObject.GetComponent<XlerdekiScript>().OyunSonuElmas(_XDegeri);
                other.gameObject.GetComponent<XlerdekiScript>().ConfettiPatlat();
                GameController._oyunBitti = true;
                GameController._oyunAktif = false;
                _playerController.WinScreenAc(_XDegeri);
                _XDegeri = 0;
            }
            else
            {

            }
        }
        else if (other.gameObject.tag == "X4")
        {
            if (PlayerController._askeriGuc <= 20)
            {
                _XDegeri = 4;
                other.gameObject.GetComponent<XlerdekiScript>().OyunSonuElmas(_XDegeri);
                other.gameObject.GetComponent<XlerdekiScript>().ConfettiPatlat();
                GameController._oyunBitti = true;
                GameController._oyunAktif = false;
                _playerController.WinScreenAc(_XDegeri);
                _XDegeri = 0;
            }
            else
            {

            }
        }
        else if (other.gameObject.tag == "X5")
        {
            if (PlayerController._askeriGuc <= 25)
            {
                _XDegeri = 5;
                other.gameObject.GetComponent<XlerdekiScript>().OyunSonuElmas(_XDegeri);
                other.gameObject.GetComponent<XlerdekiScript>().ConfettiPatlat();
                GameController._oyunBitti = true;
                GameController._oyunAktif = false;
                _playerController.WinScreenAc(_XDegeri);
                _XDegeri = 0;
            }
            else
            {

            }
        }
        else if (other.gameObject.tag == "X6")
        {
            if (PlayerController._askeriGuc <= 30)
            {
                _XDegeri = 6;
                other.gameObject.GetComponent<XlerdekiScript>().OyunSonuElmas(_XDegeri);
                other.gameObject.GetComponent<XlerdekiScript>().ConfettiPatlat();
                GameController._oyunBitti = true;
                GameController._oyunAktif = false;
                _playerController.WinScreenAc(_XDegeri);
                _XDegeri = 0;
            }
            else
            {

            }
        }
        else if (other.gameObject.tag == "X7")
        {
            if (PlayerController._askeriGuc <= 35)
            {
                _XDegeri = 7;
                other.gameObject.GetComponent<XlerdekiScript>().OyunSonuElmas(_XDegeri);
                other.gameObject.GetComponent<XlerdekiScript>().ConfettiPatlat();
                GameController._oyunBitti = true;
                GameController._oyunAktif = false;
                _playerController.WinScreenAc(_XDegeri);
                _XDegeri = 0;
            }
            else
            {

            }
        }
        else if (other.gameObject.tag == "X8")
        {
            if (PlayerController._askeriGuc <= 40)
            {
                _XDegeri = 8;
                other.gameObject.GetComponent<XlerdekiScript>().OyunSonuElmas(_XDegeri);
                other.gameObject.GetComponent<XlerdekiScript>().ConfettiPatlat();
                GameController._oyunBitti = true;
                GameController._oyunAktif = false;
                _playerController.WinScreenAc(_XDegeri);
                _XDegeri = 0;
            }
            else
            {

            }
        }
        else if (other.gameObject.tag == "X9")
        {
            if (PlayerController._askeriGuc <= 45)
            {
                _XDegeri = 9;
                other.gameObject.GetComponent<XlerdekiScript>().OyunSonuElmas(_XDegeri);
                other.gameObject.GetComponent<XlerdekiScript>().ConfettiPatlat();
                GameController._oyunBitti = true;
                GameController._oyunAktif = false;
                _playerController.WinScreenAc(_XDegeri);
                _XDegeri = 0;
            }
            else
            {

            }
        }
        else if (other.gameObject.tag == "X10")
        {
            if (PlayerController._askeriGuc <= 50 || PlayerController._askeriGuc > 50)
            {
                _XDegeri = 10;
                other.gameObject.GetComponent<XlerdekiScript>().OyunSonuElmas(_XDegeri);
                other.gameObject.GetComponent<XlerdekiScript>().ConfettiPatlat();
                GameController._oyunBitti = true;
                GameController._oyunAktif = false;
                _playerController.WinScreenAc(_XDegeri);
                _XDegeri = 0;
            }
            else
            {

            }
        }


    }
}