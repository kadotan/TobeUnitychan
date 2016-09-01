using UnityEngine;
using System.Collections;


public class  Obstacle : MonoBehaviour
{


    // Use this for initialization


    public
        float speed;

    void Start()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = transform.forward * speed;

    }

    void OnCollisionEnter(Collision hit)

    {

        if (hit.gameObject.CompareTag("Player"))
        {
            GetComponent<AudioSource>().Play();
        }

    }
}
