using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    public GameObject cylinderPrefab;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void SpawnCylinder()
    {
        float x = Random.Range(-5f, 5f);
        float y = Random.Range(-5f, 5f);
        Instantiate(cylinderPrefab, new Vector3(x, 1, y), Quaternion.identity);
    }
}
