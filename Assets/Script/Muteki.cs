using UnityEngine;
using System.Collections;
using System;

public class Muteki : MonoBehaviour
{
    void OnCollisionEnter(Collision hit)
    //void OnTriggerEnter(Collider hit)
    {
        Debug.Log("ok");
        if (hit.gameObject.CompareTag("Obstacle"))
        {
            Rigidbody a = GetComponent<Rigidbody>();
            gameObject.layer = LayerMask.NameToLayer("PlayerDamage2");
            StartCoroutine(DamageEffectMethod(1.0f, () =>
            {
                Debug.Log("ok");
                gameObject.layer = LayerMask.NameToLayer("Player");
            }));
        }
    }

    public IEnumerator DamageEffectMethod(float waitTime, Action action)
    {
        yield return new WaitForSeconds(waitTime);
        action();
    }
}
