using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{
    public GameObject Platform1;
    public GameObject Platform2;
    public GameObject Platform3;
    List<GameObject> Platforms = new List<GameObject>();
    public float countdown4 = 4f;

    void Start()
    {
        Platforms.Add(Platform1);
        Platforms.Add(Platform2);
        Platforms.Add(Platform3);
    }

    void Update()
    {
        countdown4 -= Time.deltaTime;
        if (countdown4 <= 0)
        {
            Spawn(Random.Range(0, 2));
            countdown4 = 4f;
        }
    }
    void Spawn(int i)
    {
        Vector3 pos = new Vector3(16, Random.Range(-1.5f , 0.6f), 0);
        GameObject goodsPrefab = Platforms[i];
        Instantiate(goodsPrefab, pos, goodsPrefab.transform.rotation);
    }
}
