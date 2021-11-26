using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public static bool _oyunAktif;
    public static bool _oyunBitti;
    public static bool _finishCizgisi;


    void Start()
    {
        _oyunAktif = false;
        _oyunBitti = false;
        _finishCizgisi = false;

    }


}
