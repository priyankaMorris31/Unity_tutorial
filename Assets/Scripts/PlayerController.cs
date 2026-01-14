using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // this is player Scontrol
    private float speed = 5.0f;
    private float turnSpeed = 10.0f;
    private float horizontalInput;
    private float forwardInput;
    public PlayerController(float turnSpeed)
    {
        this.turnSpeed = turnSpeed;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // this is player input 
        horizontalInput = Input.GetAxis("Horizontal");
        // Move the vichcle Forword
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
