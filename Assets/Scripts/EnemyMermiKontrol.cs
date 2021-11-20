using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMermiKontrol : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] GameObject PlayeraCarpmaFX;
    private bool playeraCarptiControl;
    public static bool yenidenAtesle;
    private bool playerVurulma;
    void Start()
    {
        playeraCarptiControl = false;
        yenidenAtesle = false;
        playerVurulma = false;
    }

    void Update()
    {
        if (playerVurulma==false)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            other.gameObject.SetActive(true);
            playeraCarptiControl = true;
            other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            PlayeraCarpmaFX.SetActive(true);
            PlayeraCarpmaFX.GetComponent<ParticleSystem>().Play();
            yenidenAtesle = true;
            playerVurulma = true;
            Destroy(gameObject, 1);
        }
        else
        {

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag=="AtesHatti")
        {
            if (playeraCarptiControl == false)
            {
                yenidenAtesle = true;
                Destroy(gameObject);
            }
            else
            {

            }
        }
        else
        {

        }
    }




}
