using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Autowalk3 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.position+=Camera.main.transform.forward * 5 * Time.deltaTime;	
	}
	public void OnTriggerEnter(Collider other)
	{if (other.gameObject.CompareTag ("trophy")) {
			SceneManager.LoadScene ("EndScene");
		}
	}
}
