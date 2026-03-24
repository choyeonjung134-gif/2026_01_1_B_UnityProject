using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float jumrForce = 5.0f;

    public Rigidbody rb;

    public bool isGrounded = true;

    public int coinCount = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //움직임 입력
        float moveHeorizontal = Input.GetAxis("Horizontal");
        float moveVertical = InPut.GetAxis("Vertical");

        rb.linearVelocity = new Vector3(moveHeorizontal * moveSpeed, moveVertical * moveSpeed);

        if(Input.GetButtonDown("Jump")&& isGrounded)
        {
            rb.AddForce(Vector3.up * jumrForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }
    private void OnCollisionEnter(Collosion collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
}


private void OnTriggerEnter(Collider other)
{
    if(other.CompareTag("Coin"))
    {
        coinCount +=;
        Destroy(other.gameObject);
    }
}
