using UnityEngine;
using System.Collections;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using Score = UnityEngine.SocialPlatforms.Impl.Score;

public class PointUp : MonoBehaviour
{
    private object collision;
    public int scoreValue;





    // Use this for initialization
    void Start()
    {

    }

    void OnTriggerEnter(Collider hit)
    {

        if (hit.CompareTag("Player"))
        {


            Scores.score += scoreValue;
            Destroy(gameObject);
        }

    }
}

