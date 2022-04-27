using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject fp;
    public float mouseSens = 50;
    public float speed = 15;
    float xRotation = 0;
    public CharacterController characterController;
    Vector3 velocity;

    void Update()
    {
        float mouseXAxis = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseYAxis = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        xRotation -= mouseYAxis;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        fp.gameObject.transform.Rotate(Vector3.up * mouseXAxis);

        float horizontal = Input.GetAxis("Horizontal");
        float verticle = Input.GetAxis("Vertical");

        Vector3 move = fp.transform.right * horizontal + fp.transform.forward * verticle;

        characterController.Move(move * speed * Time.deltaTime);
        if (!characterController.isGrounded)
        {
            velocity.y += -9.81f * Time.deltaTime;

            characterController.Move(velocity * Time.deltaTime);
        }
        else
            velocity.y = 0;
        
    }
}
