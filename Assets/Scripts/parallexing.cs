using System.Collections;
using UnityEngine;

public class parallexing : MonoBehaviour
{

    public Transform[] backgroungs;
    private float[] parascales;
    public float smooth = 1f;
    private Transform camera;
    private Vector3 PreCamPos;

    void Awake()
    {
        camera = Camera.main.transform;
    }
    // Start is called before the first frame update
    void Start()
    {
        PreCamPos = camera.position;

        parascales = new float[backgroungs.Length];
        for (int i = 0; i < backgroungs.Length; i++)
        {
            parascales[i] = backgroungs[i].position.z * -1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < backgroungs.Length; i++)
        {
            float parallax = (PreCamPos.x - camera.position.x) * parascales[i];
            float BackgroundNextPosX = backgroungs[i].position.x + parallax;
            Vector3 BackgroundNextPos = new Vector3(BackgroundNextPosX, backgroungs[i].position.y, backgroungs[i].position.z);
            backgroungs[i].position = Vector3.Lerp(backgroungs[i].position, BackgroundNextPos, smooth * Time.deltaTime);
        }

        PreCamPos = camera.position;
    }
}
