using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ObjectsPool : MonoBehaviour {

    GameObject objectToPool;         // objeto original
    int amountToPool;                // quantidade total de objetos a serem gerados
    bool canGrow = false;            // pode aumentar em tempo de execução?
    List<GameObject> pooledObjects;  // lista de objetos   

    public ObjectsPool(GameObject obj, int amount, bool grows)
    {
        objectToPool = obj;
        amountToPool = amount;
        canGrow = grows;
    }
    
    void Start () {

        // cria a qtde de objetos especificada
        pooledObjects = new List<GameObject>();  
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject obj = Instantiate(objectToPool, gameObject.transform);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
	}
	
    public GameObject getBullet ()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
                return pooledObjects[i];
        }

        if (canGrow)
        {
            GameObject obj = (GameObject)Instantiate(objectToPool);
            pooledObjects.Add(obj);
            return obj;
        }

        return null;
    }
}
