using UnityEngine;
using System.Collections;

public class BagSpawner : MonoBehaviour {
    public GameObject dollarBag;
    public float maxPos = 6.0f;
    public float timer;
    public float delayTimer = 2.5f;


	// Use this for initialization
	void Start () {

        timer = delayTimer;
	}
	
	// Update is called once per frame
	void Update () {

        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            // instantiate a car when timer = 0 sec
            Vector3 dollarBagPos = new Vector3(Random.Range(-6.0f, 6.0f), transform.position.y, transform.position.z);
            Instantiate(dollarBag, dollarBagPos, transform.rotation);
            timer = delayTimer; //reset timer to 1 sec
        }
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "DodgerMan")
        {
            Destroy(gameObject);
        }
    }
}
