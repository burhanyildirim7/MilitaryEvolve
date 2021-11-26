using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunSonuAskerKontrol : MonoBehaviour
{
    [SerializeField] GameObject mermiObjesi;
    [SerializeField] GameObject mermiAtesFX;
    //[SerializeField] Animator enemyAnimator;
    [SerializeField] float missileSpeed;

    [SerializeField] private bool _player;


    private bool mermiAtesle;
    private bool karakterAtesEtsin;
    private GameObject tempMermi;
    private GameObject tempFX;
    void Start()
    {
        // enemyAnimator.SetBool("OturarakAtes", false);
        // enemyAnimator.SetBool("AyaktaAtes", false);
        // enemyAnimator.SetBool("AyaktaAsker", true);
        mermiAtesle = true;
        // karakterAtesEtsin = false;
        // mermiAtesle = true;
    }

    void Update()
    {
        //karakterAtesEtsin = true;
        if (GameController._finishCizgisi == true && GameController._oyunBitti == false)
        {
            if (mermiAtesle == true)
            {
                StartCoroutine("mermiatesleme");
                mermiAtesle = false;
            }
        }

        //mermiAtesle = EnemyMermiKontrol.yenidenAtesle;
        //enemyAnimator.SetBool("AyaktaAtes", true);

    }


    IEnumerator mermiatesleme()
    {
        yield return new WaitForSeconds(missileSpeed);

        if (_player)
        {
            tempMermi = Instantiate(mermiObjesi, new Vector3(-100f, -100f, -100f), Quaternion.identity);
            GameObject karakter = GameObject.FindGameObjectWithTag("Karakter");
            tempMermi.transform.parent = karakter.transform;
            tempMermi.transform.localPosition = new Vector3(0f, 0f, 0.5f);
            Destroy(tempMermi, 10f);

            tempFX = Instantiate(mermiAtesFX, new Vector3(-100f, -100f, -100f), Quaternion.identity);
            tempFX.transform.parent = karakter.transform;
            tempFX.transform.localPosition = new Vector3(0f, 1.5f, 1f);
            tempFX.transform.parent = null;
            //yield return new WaitForSeconds(missileSpeed);
            mermiAtesle = true;
        }
        else
        {
            tempMermi = Instantiate(mermiObjesi, new Vector3(-100f, -100f, -100f), Quaternion.identity);
            tempMermi.transform.parent = gameObject.transform;
            tempMermi.transform.localPosition = new Vector3(0f, 0f, 0.5f);
            Destroy(tempMermi, 10f);

            tempFX = Instantiate(mermiAtesFX, new Vector3(-100f, -100f, -100f), Quaternion.identity);
            tempFX.transform.parent = transform.parent;
            tempFX.transform.localPosition = new Vector3(0f, 1.5f, 1f);
            tempFX.transform.parent = null;
            //yield return new WaitForSeconds(missileSpeed);
            mermiAtesle = true;
        }


    }
    /*
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FinishCizgisi")
        {
            mermiAtesle = true;
        }
    }
    */
}
