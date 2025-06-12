using UnityEngine;

public class PlanetOrbit : MonoBehaviour
{
    [Header("Orbit Settings")]
    public Transform sun;           // Objek Matahari sebagai pusat orbit
    public float orbitSpeed = 0f;  // Kecepatan orbit
    public float orbitRadius = 0f;  // Jarak dari matahari

    [Header("Rotation Settings")]
    public float rotationSpeed = 30f;

    private float angle;

    void Update()
    {
        OrbitAroundSun();
        SelfRotate();
    }

    void OrbitAroundSun()
    {
        if (sun == null) return;

        angle += orbitSpeed * Time.deltaTime;

        float x = Mathf.Cos(angle) * orbitRadius;
        float z = Mathf.Sin(angle) * orbitRadius;

        transform.position = sun.position + new Vector3(x, 0, z);
    }

    void SelfRotate()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}