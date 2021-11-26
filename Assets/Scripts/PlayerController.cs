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

    [SerializeField] private List<GameObject> _karakterListesi = new List<GameObject>();

    [SerializeField] private GameObject _oyunSonuBelirlemeObjesi;

    [SerializeField] private List<GameObject> _rütbeListesi = new List<GameObject>();


    public static int rutbeSayisi;
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

    private Animator _karakterAnimator;

    public static int _askeriGuc;

    private GameObject _karakter;


    void Start()
    {
        LevelStart();

        _uiController = GameObject.Find("UIController").GetComponent<UIController>();

    }

    private void Update()
    {
        Debug.Log("Askeri Güc = " + _askeriGuc.ToString());


    }




    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Rutbe")
        {
            if (rutbeSayisi < 100)
            {
                rutbeSayisi = rutbeSayisi + RankArtisDegeri;
                RankText.text = "Rank " + rutbeSayisi.ToString();

                sliderSayac++;

                if (sliderSayac > 5)
                {
                    sliderSayac = 1;
                }
                RankSlider.value = sliderSayac;

                if (rutbeSayisi <= 25)
                {
                    _karakterListesi[1].SetActive(false);
                    _karakterListesi[2].SetActive(false);
                    _karakterListesi[3].SetActive(false);
                    _karakterListesi[0].SetActive(true);

                    _rütbeListesi[1].SetActive(false);
                    _rütbeListesi[2].SetActive(false);
                    _rütbeListesi[3].SetActive(false);
                    _rütbeListesi[0].SetActive(true);

                    _karakterAnimator = GameObject.FindGameObjectWithTag("Karakter").GetComponent<Animator>();
                    _karakterAnimator.SetBool("Idle", false);
                    _karakterAnimator.SetBool("Run", true);
                }
                else if (rutbeSayisi > 25 && rutbeSayisi <= 50)
                {
                    _karakterListesi[0].SetActive(false);
                    _karakterListesi[2].SetActive(false);
                    _karakterListesi[3].SetActive(false);
                    _karakterListesi[1].SetActive(true);

                    _rütbeListesi[0].SetActive(false);
                    _rütbeListesi[2].SetActive(false);
                    _rütbeListesi[3].SetActive(false);
                    _rütbeListesi[1].SetActive(true);

                    _karakterAnimator = GameObject.FindGameObjectWithTag("Karakter").GetComponent<Animator>();
                    _karakterAnimator.SetBool("Idle", false);
                    _karakterAnimator.SetBool("Run", true);
                }
                else if (rutbeSayisi > 50 && rutbeSayisi <= 75)
                {
                    _karakterListesi[0].SetActive(false);
                    _karakterListesi[1].SetActive(false);
                    _karakterListesi[3].SetActive(false);
                    _karakterListesi[2].SetActive(true);

                    _rütbeListesi[0].SetActive(false);
                    _rütbeListesi[1].SetActive(false);
                    _rütbeListesi[3].SetActive(false);
                    _rütbeListesi[2].SetActive(true);

                    _karakterAnimator = GameObject.FindGameObjectWithTag("Karakter").GetComponent<Animator>();
                    _karakterAnimator.SetBool("Idle", false);
                    _karakterAnimator.SetBool("Run", true);
                }
                else if (rutbeSayisi > 75 && rutbeSayisi <= 100)
                {
                    _karakterListesi[0].SetActive(false);
                    _karakterListesi[1].SetActive(false);
                    _karakterListesi[2].SetActive(false);
                    _karakterListesi[3].SetActive(true);

                    _rütbeListesi[0].SetActive(false);
                    _rütbeListesi[1].SetActive(false);
                    _rütbeListesi[2].SetActive(false);
                    _rütbeListesi[3].SetActive(true);

                    _karakterAnimator = GameObject.FindGameObjectWithTag("Karakter").GetComponent<Animator>();
                    _karakterAnimator.SetBool("Idle", false);
                    _karakterAnimator.SetBool("Run", true);
                }
                else
                {

                }
            }
            else
            {
                rutbeSayisi = 100;
                RankText.text = "Rank " + rutbeSayisi.ToString();
            }


            Destroy(other.gameObject);
        }
        else if (other.tag == "Obstacles" || other.tag == "Missile")
        {
            if (rutbeSayisi > 1)
            {
                rutbeSayisi = rutbeSayisi - RankArtisDegeri;
                RankText.text = "Rank " + rutbeSayisi.ToString();

                sliderSayac--;

                if (sliderSayac < 1)
                {
                    sliderSayac = 5;
                }
                RankSlider.value = sliderSayac;

                if (rutbeSayisi <= 25)
                {
                    _karakterListesi[1].SetActive(false);
                    _karakterListesi[2].SetActive(false);
                    _karakterListesi[3].SetActive(false);
                    _karakterListesi[0].SetActive(true);

                    _rütbeListesi[1].SetActive(false);
                    _rütbeListesi[2].SetActive(false);
                    _rütbeListesi[3].SetActive(false);
                    _rütbeListesi[0].SetActive(true);

                    _karakterAnimator = GameObject.FindGameObjectWithTag("Karakter").GetComponent<Animator>();
                    _karakterAnimator.SetBool("Idle", false);
                    _karakterAnimator.SetBool("Run", true);
                }
                else if (rutbeSayisi > 25 && rutbeSayisi <= 50)
                {
                    _karakterListesi[0].SetActive(false);
                    _karakterListesi[2].SetActive(false);
                    _karakterListesi[3].SetActive(false);
                    _karakterListesi[1].SetActive(true);

                    _rütbeListesi[0].SetActive(false);
                    _rütbeListesi[2].SetActive(false);
                    _rütbeListesi[3].SetActive(false);
                    _rütbeListesi[1].SetActive(true);

                    _karakterAnimator = GameObject.FindGameObjectWithTag("Karakter").GetComponent<Animator>();
                    _karakterAnimator.SetBool("Idle", false);
                    _karakterAnimator.SetBool("Run", true);
                }
                else if (rutbeSayisi > 50 && rutbeSayisi <= 75)
                {
                    _karakterListesi[0].SetActive(false);
                    _karakterListesi[1].SetActive(false);
                    _karakterListesi[3].SetActive(false);
                    _karakterListesi[2].SetActive(true);

                    _rütbeListesi[0].SetActive(false);
                    _rütbeListesi[1].SetActive(false);
                    _rütbeListesi[3].SetActive(false);
                    _rütbeListesi[2].SetActive(true);

                    _karakterAnimator = GameObject.FindGameObjectWithTag("Karakter").GetComponent<Animator>();
                    _karakterAnimator.SetBool("Idle", false);
                    _karakterAnimator.SetBool("Run", true);
                }
                else if (rutbeSayisi > 75 && rutbeSayisi <= 100)
                {
                    _karakterListesi[0].SetActive(false);
                    _karakterListesi[1].SetActive(false);
                    _karakterListesi[2].SetActive(false);
                    _karakterListesi[3].SetActive(true);

                    _rütbeListesi[0].SetActive(false);
                    _rütbeListesi[1].SetActive(false);
                    _rütbeListesi[2].SetActive(false);
                    _rütbeListesi[3].SetActive(true);

                    _karakterAnimator = GameObject.FindGameObjectWithTag("Karakter").GetComponent<Animator>();
                    _karakterAnimator.SetBool("Idle", false);
                    _karakterAnimator.SetBool("Run", true);
                }
                else
                {

                }
            }
            else
            {
                rutbeSayisi = 1;
                RankText.text = "Rank " + rutbeSayisi.ToString();

                GameController._oyunAktif = false;
                GameController._oyunBitti = true;

                _karakterAnimator = GameObject.FindGameObjectWithTag("Karakter").GetComponent<Animator>();
                _karakterAnimator.SetBool("Run", false);
                _karakterAnimator.SetBool("Death", true);

                Invoke("LoseScreenAc", 2f);
                //LoseScreenAc();
            }

        }
        else if (other.gameObject.tag == "FinishCizgisi")
        {
            GameController._oyunAktif = false;
            GameController._finishCizgisi = true;

            _karakterAnimator.SetBool("Idle", false);
            _karakterAnimator.SetBool("Death", false);
            _karakterAnimator.SetBool("Run", false);
            _karakterAnimator.SetBool("Attack", true);

            _oyunSonuBelirlemeObjesi.SetActive(true);

            if (rutbeSayisi > 25)
            {
                _karakter = GameObject.FindGameObjectWithTag("Karakter");
                _karakter.transform.localRotation = Quaternion.Euler(0, 60, 0);
            }
            else
            {

            }

            //GameController._oyunBitti = true;
        }
        else
        {

        }


    }


    public void WinScreenAc(int deger)
    {
        _uiController.WinScreenPanelOpen(deger);
    }

    private void LoseScreenAc()
    {
        _uiController.LoseScreenPanelOpen();
    }

    public void KarakterRun()
    {
        _karakterAnimator = GameObject.FindGameObjectWithTag("Karakter").GetComponent<Animator>();
        _karakterAnimator.SetBool("Idle", false);
        _karakterAnimator.SetBool("Run", true);
    }




    public void LevelStart()
    {
        GameController._oyunBitti = false;
        GameController._finishCizgisi = false;
        _toplananElmasSayisi = 1;
        rutbeSayisi = 1;
        sliderSayac = 1;
        _askeriGuc = 0;
        RankSlider.value = sliderSayac;
        RankText.text = "Rank 1";
        _karakterListesi[1].SetActive(false);
        _karakterListesi[2].SetActive(false);
        _karakterListesi[3].SetActive(false);
        _karakterListesi[0].SetActive(true);
        _rütbeListesi[1].SetActive(false);
        _rütbeListesi[2].SetActive(false);
        _rütbeListesi[3].SetActive(false);
        _rütbeListesi[0].SetActive(true);
        _karakterAnimator = GameObject.FindGameObjectWithTag("Karakter").GetComponent<Animator>();
        _karakterAnimator.SetBool("Attack", false);
        _karakterAnimator.SetBool("Death", false);
        _karakterAnimator.SetBool("Run", false);
        _karakterAnimator.SetBool("Idle", true);
        zirhliSag = false;
        zirhliSol = false;
        heliSag = false;
        heliSol = false;
        tankSag = false;
        tankSol = false;
        _karakterPaketi.transform.position = new Vector3(0, 0, 0);
        _karakterPaketi.transform.rotation = Quaternion.Euler(0, 0, 0);
        _karakter = GameObject.FindGameObjectWithTag("Karakter");
        _karakter.transform.localRotation = Quaternion.Euler(0, 0, 0);
        _player = GameObject.FindWithTag("Player");
        _player.transform.localPosition = new Vector3(0, 0, 0);
        _oyunSonuBelirlemeObjesi.SetActive(false);
        _oyunSonuBelirlemeObjesi.transform.localPosition = new Vector3(0, 2, 0);

    }



}
