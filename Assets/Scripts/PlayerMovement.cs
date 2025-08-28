using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // variables
    Vector3 movementVector;
    [SerializeField] float Speed = 1;
    [SerializeField] float jumpForce = 1;
    bool grounded;

    // refrences 
    [SerializeField] Transform myCamera;
    [SerializeField] Animator myAnimator;
    //[SerializeField] PlayerHealth ph; // comment for now!
    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        myAnimator.SetFloat("walkSpeed", movementVector.magnitude);
        myAnimator.SetFloat("ground", myAnimator.transform.position.y);
    }
    private void FixedUpdate()
    {
       rb.AddForce(movementVector * Speed, ForceMode.Acceleration); 
    }

    /*public void Damage()
    {
        ph.health--;
    }*/

    void OnMovement(InputValue v)
    {
        Debug.Log("OnMovement Called!");
        Vector2 inputVector = v.Get<Vector2>();
        movementVector = new Vector3(inputVector.x, 0, inputVector.y);
        myAnimator.transform.forward = movementVector.normalized;


        
    }

    void OnJump()
    {
        Debug.Log("OnJump Called!");
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        myAnimator.SetTrigger("jump");


    }
}
