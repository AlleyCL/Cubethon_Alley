using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce;
    public float sidewaysForce;

    // Start is called before the first frame update
    void Start()
    {

    }

    // use FixedUpdate to mess w/ physics
    void FixedUpdate()
    {
        //add forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        //Move Right
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        //Move Left
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        //Lose game if fall off
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
