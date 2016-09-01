using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HeartController : MonoBehaviour
{

    public GameObject Controller;
    public Slider healthSlider;
    public int cure;
    // Use this for initialization
    void Start()
    {

    }



    void OnTriggerEnter(Collider hit)
    {

        if (hit.CompareTag("Player"))
        {

            Controller = GameObject.FindGameObjectWithTag("Player");


            Destroy(gameObject);
        }


    }
}


