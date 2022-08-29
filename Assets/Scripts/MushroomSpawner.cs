using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomSpawner : MonoBehaviour
{
    [SerializeField]private GameObject objPrefab;
    [SerializeField]private int amountPool = 20;
    [SerializeField] private List<GameObject> pooledObject;
    private float timer;

    private void Awake()
    {
        pooledObject = new List<GameObject>();
    }
    private void Start()
    {
        for (int i = 0; i < amountPool; i++)
        {
            GameObject obj = Instantiate(objPrefab, transform.position, Quaternion.identity, transform);
            obj.SetActive(false);
            pooledObject.Add(obj);
        }
    }

    void FixedUpdate()
    {
        //Instantiate(objPrefab, transform.position, Quaternion.identity,transform);
        SpawnObjectPool();
    }

    private void SpawnObjectPool()
    {
        GameObject objectPool = PoolObject();
        timer += Time.deltaTime;
        if(timer>0.3)
        {
            if (objectPool != null)
            {
                objectPool.transform.position = this.transform.position;
                objectPool.SetActive(true);
            }
            timer = 0;
        }
    }

    private GameObject PoolObject()
    {
        for (int i = 0; i < pooledObject.Count; i++)
        {
            if(!pooledObject[i].activeInHierarchy)
            {
                return pooledObject[i];
            }
        }
        return null;
    }
}
