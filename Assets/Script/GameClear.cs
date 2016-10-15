using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameClear : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision hit) {
        if (hit.gameObject.CompareTag("Player")) {
            SceneManager.LoadScene("GameClear");
        }
    }
}
