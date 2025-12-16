using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // Ref till Player
    public float smoothSpeed = 0.125f; // Hastigheten som kameran rör sig i, höj / sänk om kameran blir skakig
    public Vector3 offset; // Mellanrummet mellan player och kameran
    public float rotationSpeed = 1.5f; // Hastighet för att rotera kameran
    private float mouseX, mouseY; // Uppdatera kamerans position beroende på vart spelaren ställer den
    void LateUpdate()
    {
        if (Input.GetMouseButton(1)) // Kolla om vi trycker på höger musknapp
        {
            mouseX += Input.GetAxis("Mouse X") * rotationSpeed; // Hämta mus position i X, gånger rotations hastigheten
            mouseY -= Input.GetAxis("Mouse Y") * rotationSpeed; // Hämta mus position i Y, gånger rotations hastigheten
            mouseY = Mathf.Clamp(mouseY, -35f, 60f); // Hindra kameran från att rotera för långt runt
        }
        // Räkna ut rotationen och positionen av kameran
        Quaternion rotation = Quaternion.Euler(mouseY, mouseX, 0);
        Vector3 desiredPosition = target.position - (rotation * offset);
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        // Flytta och rotera kameran
        transform.position = smoothedPosition;
        transform.LookAt(target);
    }
}
