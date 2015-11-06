using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PlayerControl : MonoBehaviour {

    public float speed;
    public float maxPos = 6.0f;

    public uiManager manger;


    Vector2 position;
    Animator anim;
	// Use this for initialization
	void Start () {

        position = transform.position; //assigning the car current position to position var
        anim = GetComponent<Animator>();

       
	}
   
	
	// Update is called once per frame
	void Update () {
        
        Movement();
       // position.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime; // incrementing the value of the x position 
        position.x = Mathf.Clamp(position.x, -6.0f, 6.0f);
        transform.position = position;

        anim.SetFloat("speed", Mathf.Abs(Input.GetAxis("Horizontal")));
       // transform.eulerAngles = new Vector2(0, 180); //this sets the rotation of the gameobject
       
	}
    void OnCollisionEnter2D(Collision2D col)
    {

        if(col.gameObject.tag =="Ghost Skull")
        {
            Destroy(gameObject); // destroy our man
            manger.GameOver();
           
        }
       
    }

    void Movement() //function that stores all the movement
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            position.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime; // incrementing the value of the x position 
            //transform.Translate(Vector3.right * speed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0); //this sets the rotation of the gameobject
            
        }

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            position.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime; // incrementing the value of the x position 
            //transform.Translate(Vector3.right * speed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 180); //this sets the rotation of the gameobject
        }

       
    }
}
