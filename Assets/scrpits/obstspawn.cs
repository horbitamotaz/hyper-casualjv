using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstspawn : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject obstacle;
    public float height;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newobstacle = Instantiate(obstacle);
            newobstacle.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newobstacle, 15);
            timer = 0;

        }

        timer += Time.deltaTime;
    }
}
