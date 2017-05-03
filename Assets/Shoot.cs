using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //  GameObject.FindGameObjectWithTag("poolManager").GetComponent<PoolManager>()
            //if (PoolManager.Instance.GetPool("bullets"))
            //{
            //    GameObject bullet = PoolManager.Instance.GetPool("bullets").getBullet();
            //if (bullet)
            //    {
            //        bullet.transform.position = gameObject.transform.position + new Vector3(2, 0, 0);
            //        bullet.transform.rotation = Quaternion.identity;
            //        bullet.SetActive(true);
            //    }
            //}
            
        }
	}
}
