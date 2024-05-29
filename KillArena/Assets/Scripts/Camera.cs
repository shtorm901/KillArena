using UnityEngine;

public class Camera : MonoBehaviour
{
    public float Sensivity = 0.5f;
    public float MaxYAngle = 80f;

    private float RotationX = 0f;
    private float MouseX;
    private float MouseY;

    public void Update()
    {
        Rotation();
    }

    public void Rotation()
    {
        MouseX = Input.GetAxis("Mouse X");
        MouseY = Input.GetAxis("Mouse Y");
        Cursor.lockState = CursorLockMode.Locked;

        transform.parent.Rotate(Vector3.up * MouseX * Sensivity);

        RotationX -= MouseY * Sensivity;
        RotationX = Mathf.Clamp(RotationX, -MaxYAngle, MaxYAngle);
        transform.localRotation = Quaternion.Euler(RotationX, 0.0f, 0.0f);
    }
}
