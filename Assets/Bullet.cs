using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public int damage = 1; 

	// Use this for initialization
	void Start () {
		 
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.activeInHierarchy)
        {
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(10, 0, 0);
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
    }

}
