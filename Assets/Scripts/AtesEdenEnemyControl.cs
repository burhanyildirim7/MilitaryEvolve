using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class AtesEdenEnemyControl : MonoBehaviour
{
    [SerializeField] GameObject mermiObjesi;
    [SerializeField] GameObject mermiAtesFX;
    [SerializeField] Animator enemyAnimator;
    [SerializeField] float missileSpeed;


    private bool mermiAtesle;
    private bool karakterAtesEtsin;
    private GameObject tempMermi;
    private GameObject tempFX;
    void Start()
    {
        enemyAnimator.SetBool("OturarakAtes", false);
        enemyAnimator.SetBool("AyaktaAtes", false);
        enemyAnimator.SetBool("AyaktaAsker", true);
        mermiAtesle = false;
        karakterAtesEtsin = false;
       // mermiAtesle = true;
    }

    void Update()
    {
        //karakterAtesEtsin = true;

        if (karakterAtesEtsin == true)
        {
            if (mermiAtesle == true)
            {
                StartCoroutine("mermiatesleme");
                mermiAtesle = false;
            }
            //mermiAtesle = EnemyMermiKontrol.yenidenAtesle;
            enemyAnimator.SetBool("AyaktaAtes", true);
        }
        else
        {
            enemyAnimator.SetBool("AyaktaAtes", false);
        }
    }

      private void OnTriggerEnter(Collider other)
       {
           Debug.Log("girdi");
        if (other.tag == "Player" )
           {
               karakterAtesEtsin = true;
               mermiAtesle = true;
           }
       }
       private void OnTriggerExit(Collider other)
       {
           Debug.Log("??kt?");
           if (other.tag == "Player")
           {
               karakterAtesEtsin = false;
             
        }
       }
    IEnumerator mermiatesleme()
    {

        tempMermi = Instantiate(mermiObjesi, new Vector3(-100f, -100f, -100f), Quaternion.identity);
        tempMermi.transform.parent = transform.parent;
        tempMermi.transform.localPosition = new Vector3(0f, 0f, -0.5f);

        tempFX = Instantiate(mermiAtesFX, new Vector3(-100f, -100f, -100f), Quaternion.identity);
        tempFX.transform.parent = transform.parent;
        tempFX.transform.localPosition = new Vector3(0f, 3f, -1.5f);
        tempFX.transform.parent = null;
        yield return new WaitForSeconds(missileSpeed);
        mermiAtesle = true;
        if (karakterAtesEtsin == false)
        {
            mermiAtesle = false;
        }
    }
}
