using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeGroundManager : MonoBehaviour
{
    public GameObject Lava;
    public float countdown5 = 0.1f;

    void Start()
    {

    }

    void Update()
    {
        countdown5 -= Time.deltaTime;
        if (countdown5 <= 0)
        {
            Spawn();
            countdown5 = 16f;
        }
    }
    void Spawn()
    {
        Vector3 pos = new Vector3(15.85f, -3.89f, 0);
        GameObject goodsPrefab = Lava;
        Instantiate(goodsPrefab, pos, goodsPrefab.transform.rotation);
    }
}
