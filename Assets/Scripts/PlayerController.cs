using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private int RankArtisDegeri;

    // [SerializeField] private int _kötüToplanabilirDeger;

    [SerializeField] private GameObject _karakterPaketi;
    [SerializeField] Text RankText;
    [SerializeField] Slider RankSlider;

    private int rutbeSayisi;
    private int sliderSayac;

    private GameObject _player;

    private UIController _uiController;

    private int _toplananElmasSayisi;

    public static bool zirhliSag;
    public static bool zirhliSol;
    public static bool heliSag;
    public static bool heliSol;
    public static bool tankSag;
    public static bool tankSol;


    void Start()
    {
        LevelStart();

        _uiController = GameObject.Find("UIController").GetComponent<UIController>();
        rutbeSayisi = 1;
        sliderSayac = 1;
        RankSlider.value = sliderSayac;
        RankText.text = "Rank 1";

        zirhliSag = false;
        zirhliSol = false;
        heliSag = false;
        heliSol = false;
        tankSag = false;
        tankSol = false;

    }




    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Rutbe")
        {
            rutbeSayisi = rutbeSayisi + RankArtisDegeri;
            RankText.text = "Rank " + rutbeSayisi.ToString();
            sliderSayac++;
            if (sliderSayac > 5)
            {
                sliderSayac = 1;
            }
            RankSlider.value = sliderSayac;

            Destroy(other.gameObject);
        }
        else if (other.tag == "Obstacles" || other.tag == "Missile")
        {
            rutbeSayisi = rutbeSayisi - RankArtisDegeri;
            RankText.text = "Rank " + rutbeSayisi.ToString();
            sliderSayac--;
            if (sliderSayac < 1)
            {
                sliderSayac = 5;
            }
            RankSlider.value = sliderSayac;
        }
        else
        {

        }


    }

    private void WinScreenAc()
    {
        _uiController.WinScreenPanelOpen();
    }

    private void LoseScreenAc()
    {
        _uiController.LoseScreenPanelOpen();
    }




    public void LevelStart()
    {
        _toplananElmasSayisi = 1;
        _karakterPaketi.transform.position = new Vector3(0, 0, 0);
        _karakterPaketi.transform.rotation = Quaternion.Euler(0, 0, 0);
        _player = GameObject.FindWithTag("Player");
        _player.transform.localPosition = new Vector3(0, 0, 0);
    }



}
