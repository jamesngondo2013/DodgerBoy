using UnityEngine;
using System.Collections;

public class GhostSpawner : MonoBehaviour {

    public GameObject ghost;
    public float maxPos = 6.0f;
    public float timer;
    public float delayTimer = 0.5f;



    // Use this for initialization
    void Start()
    {
        timer = delayTimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if(timer <=0)
        {
            // instantiate a car when timer = 0 sec
            Vector3 ghostPos = new Vector3(Random.Range(-6.0f, 6.0f), transform.position.y, transform.position.z);
            Instantiate(ghost, ghostPos, transform.rotation);
            timer = delayTimer; //reset timer to 1 sec
        }
       
    }
}
