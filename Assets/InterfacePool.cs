using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfacePool : MonoBehaviour {

    public string poolName;
    public GameObject poolObject;
    public int poolSize;

    // Use this for initialization
	void Start () {
        ObjectPoolingManager.Instance.CreatePool(poolObject, poolSize, 10, transform);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Jump"))
        {
            GameObject bullet = ObjectPoolingManager.Instance.GetObject("Cube");
            bullet.transform.position = transform.position;
            bullet.transform.rotation = Quaternion.identity;
            bullet.SetActive(true);
        }
	}


}
