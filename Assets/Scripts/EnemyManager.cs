using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject Enemy1;
    List<GameObject> Enemies = new List<GameObject>();
    public float countdown1 = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        Enemies.Add(Enemy1);
    }

    // Update is called once per frame
    void Update()
    {
        countdown1 -= Time.deltaTime;
        if (countdown1 <= 0)
        {
            Spawn(0);
            countdown1 = 3.5f;
        }
    }
    void Spawn(int i)
    {
        Vector3 pos = new Vector3(10, Random.Range(-0.5f , 2f), 0);
        GameObject goodsPrefab = Enemies[i];
        Instantiate(goodsPrefab, pos, goodsPrefab.transform.rotation);
    }
}
