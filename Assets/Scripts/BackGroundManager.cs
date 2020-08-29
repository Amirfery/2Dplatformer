using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundManager : MonoBehaviour
{
    public GameObject Back1;
    public GameObject Back2;
    public GameObject Back3;
    List<GameObject> Screens = new List<GameObject>();
    public float countdown1 = 0f;
    public float countdown2 = 0f;
    public float countdown3 = 0f;

    void Start()
    {
        Screens.Add(Back1);
        Screens.Add(Back2);
        Screens.Add(Back3);
    }

    void Update()
    {
        countdown1 -= Time.deltaTime;
        countdown2 -= Time.deltaTime;
        countdown3 -= Time.deltaTime;

        if (countdown1 <= 0)
        {
            Spawn(0);
            countdown1 = 17.78f;
        }
        if (countdown2 <= 0)
        {
            Spawn(1);
            countdown2 = 26.67f;
        }
        if (countdown3 <= 0)
        {
            Spawn(2);
            countdown3 = 53.34f;
        }
    }
    public void Spawn(int i)
    {
        Vector3 pos = new Vector3(16, Screens[i].transform.position.y, 0);
        GameObject goodsPrefab = Screens[i];
        Instantiate(goodsPrefab, pos, goodsPrefab.transform.rotation);
    }
}
