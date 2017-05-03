using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(PoolManager))]
public class PoolManagerEditor : Editor {

    PoolManager pool;
    int totalPools;
    //List<GameObject> objectToPool = new List<GameObject>();
    //List<string> poolName = new List<string>();
    //List<int> amountToPool = new List<int>();
    //List<bool> canGrow = new List<bool>();

    private void OnEnable()
    {
        pool = (PoolManager)target;
       // pool.pools = new Dictionary<string, ObjectsPool>();
       // Clear();
    }

    public override void OnInspectorGUI()
    {
        //     totalPools = EditorGUILayout.IntSlider("Number of Pools: ", totalPools, 1, 10);

        base.OnInspectorGUI();

        //   DrawPoolProperties();
        if (GUILayout.Button("Add Pool"))
        {
            NewPool();
            EditorUtility.SetDirty(pool);
        }
    }


    void DrawPoolProperties()
    {
        for (int i = 0; i < totalPools; i++)
        {
            EditorGUI.BeginChangeCheck();
            EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);

            EditorGUILayout.LabelField("Pool Name: ");
            pool.poolName[i] = (GUILayout.TextField(pool.poolName[i]));

            pool.canGrow[i] = (EditorGUILayout.Toggle("Can Grow", pool.canGrow[i]));

            pool.objectToPool[i] = ((GameObject) EditorGUILayout.ObjectField("Prefab: ", pool.objectToPool[i], typeof(GameObject), false));
            pool.amountToPool[i] = (EditorGUILayout.IntField("Amount of Objects: ", pool.amountToPool[i]));
        }
    }

    void NewPool()
    {
        for (int i = 0; i < pool.poolName.Count; i++)
        {
            if (pool.poolName[i] != "" && pool.objectToPool[i] != null && pool.amountToPool[i] >= 1)
            {
                pool.CreatePool(pool.poolName[i], new ObjectsPool(pool.objectToPool[i], pool.amountToPool[i], pool.canGrow[i]));
            }          
        }
        Debug.Log(pool.GetPool("bullets"));
        Debug.Log(pool.pools.Count);
    }

    //void Clear()
    //{
    //    for (int i = 0; i < 10; i++)
    //    {
    //        pool.objectToPool.Add(null);
    //        pool.poolName.Add("");
    //        pool.amountToPool.Add(0);
    //        pool.canGrow.Add(true);
    //    }
    //}
}
