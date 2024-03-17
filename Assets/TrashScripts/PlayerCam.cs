using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public float sensX; // Sensitivity for X-axis movement
    public float sensY; // Sensitivity for Y-axis movement

    public Transform orientation; // Reference to the player's orientation

    private float xRotation; // Current X rotation angle
    private float yRotation; // Current Y rotation angle

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false; // Setting visibility to false
    }

    private void Update()
    {
        // Getting input for mouse movement
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY; // Corrected to "Mouse Y"

        // Adjusting rotation angles
        yRotation += mouseX;
        xRotation -= mouseY; // Corrected to subtract mouseY

        // Clamping X rotation to prevent flipping
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        
        // Applying rotation to the camera
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        
        // Applying rotation to the player's orientation
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}