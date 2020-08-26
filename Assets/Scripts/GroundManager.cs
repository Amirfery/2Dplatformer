using UnityEngine;

public class GroundManager : MonoBehaviour
{
    public GameObject Platform;
    public float countdown4 = 4f;

    void Start()
    {

    }

    void Update()
    {
        countdown4 -= Time.deltaTime;
        if (countdown4 <= 0)
        {
            Spawn();
            countdown4 = 4f;
        }
    }
    void Spawn()
    {
        Vector3 pos = new Vector3(10, Random.Range(-1 , -4), 0);
        GameObject goodsPrefab = Platform;
        Instantiate(goodsPrefab, pos, goodsPrefab.transform.rotation);
    }
}
