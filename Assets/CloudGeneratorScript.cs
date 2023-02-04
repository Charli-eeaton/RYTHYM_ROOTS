using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudGeneratorScript : MonoBehaviour
{
    [SerializeField]
    GameObject[] clouds;

    [SerializeField]
    float spawnInterval;

    [SerializeField]
    GameObject endPoint;

    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;

        Invoke("AttemptSpawn", spawnInterval);


    }

    void AttemptSpawn()
    {
        //check if game running/player dead/ext
        SpawnCloud();
        Invoke("AttemptSpawn", spawnInterval);
    }

    void SpawnCloud()
    {
        //random order
        int randomIndex = UnityEngine.Random.Range(0, clouds.Length);
        GameObject cloud = Instantiate(clouds[randomIndex]);

        //random size
        float scale = UnityEngine.Random.Range(0.8f, 1.2f);
        cloud.transform.localScale = new Vector2(scale, scale);

        //random pos
        startPos.y = UnityEngine.Random.Range(startPos.y - 1f, startPos.y + 1f);
        cloud.transform.position = startPos;

        //random speed
        float speed = UnityEngine.Random.Range(0.5f, 1.5f);
        cloud.GetComponent<cloud_script>().StartFloating(speed, endPoint.transform.position.x);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
