using System;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

[System.Serializable]
public class Boundary
{
    public float yMin, yMax, zMin, zMax;
}

public class controller : MonoBehaviour
{
    public float speed;
    public GameObject Heart;
    public Boundary boundary;

    public int startingHealth = 100;
    public int currentHealth;
    public Slider healthSlider;
    public int damage;
    public int cure;

    public GameObject player;

    public int scoreValue;


    // Use this for initialization



    void Start()
    {

        currentHealth = startingHealth;
       

    }

    // Update is called once per frame
    void Update()


    {

        Rigidbody rigidbody = GetComponent<Rigidbody>();
        
        float z = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        rigidbody.AddForce(0, y * speed, 0);

        Vector3 movement = new Vector3(0.0f, y, z);
        rigidbody.position = new Vector3
            (
            0.0f,
            Mathf.Clamp(rigidbody.position.y, boundary.yMin, boundary.yMax),

            Mathf.Clamp(rigidbody.position.z, boundary.zMin, boundary.zMax)
            );
    }

    void OnCollisionEnter(Collision hit)

    {

        if (hit.gameObject.CompareTag("Obstacle"))
        {

            currentHealth -= damage;

            GetComponent<AudioSource>().Play();
            healthSlider.value = currentHealth;


            //gameObject.layer = LayerMask.NameToLayer("PlayerDamage");

            //StartCoroutine(DamageEffectMethod(3.0f, () =>
            //{
               
            //    gameObject.layer = LayerMask.NameToLayer("Player");
            //}));

        }
    
}

    void OnTriggerEnter(Collider hit)
    {

        if (hit.CompareTag("Heart"))
        {

            currentHealth += cure;

            Scores.score += scoreValue;

            healthSlider.value = currentHealth;

        }

    }

    void Die()
    {
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }


   
    public IEnumerator DamageEffectMethod(float waitTime, Action action)
    {
        yield return new WaitForSeconds(waitTime);
        action();
    }

}



