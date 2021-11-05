using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//The movement from this script was used from the Lab excercise 2
public class Movement : MonoBehaviour
{
   
    public float speed = 4;
    private Rigidbody2D rb;
    private float dirX, dirY;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizontal") * speed;
        dirY = Input.GetAxis("Vertical") * speed;
        //if stuck
        if (Input.GetKeyDown("space")) 
        {
            SceneManager.LoadScene("Game");
        }
        

    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, dirY);
    }
}
