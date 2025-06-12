using UnityEngine;

public class MoonOrbit : MonoBehaviour
{
    public float orbitSpeed = 20f; // Kecepatan orbit dalam derajat per detik

    void Update()
    {
        // Rotasi di sekitar sumbu Y lokal (putaran horizontal)
        transform.Rotate(Vector3.up * orbitSpeed * Time.deltaTime);
    }
}
