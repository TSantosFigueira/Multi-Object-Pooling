using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{

    public Dictionary<string, ObjectsPool> pools = null;
    public static PoolManager instance = null;

    public List<GameObject> objectToPool = new List<GameObject>();
    public List<string> poolName = new List<string>();
    public List<int> amountToPool = new List<int>();
    public List<bool> canGrow = new List<bool>();

    //public static PoolManager Instance   // Encapsulamento do Pool Manager
    //{
    //    get
    //    {
    //        if (instance == null)
    //        {
    //            instance = new PoolManager();
    //            instance.pools = new Dictionary<string, ObjectsPool>();
    //        }
    //        return instance;
    //    }
    //}

    public bool CreatePool(string name, ObjectsPool pool)
    {
        if (CreateManager())
        {
            if (!pools.ContainsKey(name))
                pools.Add(name, pool);
        }
        return false;
    }

    public bool GetPool(string name)
    {
        if (pools.ContainsKey(name))
            return true;
        return false;
    }



    bool CreateManager()
    {
        if (pools == null)
        {
            pools = new Dictionary<string, ObjectsPool>();
        }
        return true;
    }
}
