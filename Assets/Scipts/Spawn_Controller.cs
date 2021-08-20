using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Controller : MonoBehaviour
{


    public GameObject pipePreFab;

    public float minY;

    public float maxY;

    public float x;
    
    public float interval;


    void Start()
    {
        InvokeRepeating("spawn", interval, interval);
    }

    
    void Update()
    {
        
    }

    private void spawn () 
    {
        GameObject instance = Instantiate(pipePreFab);
        instance.transform.position = new Vector2(x, Random.Range(minY, maxY));
    }
}
