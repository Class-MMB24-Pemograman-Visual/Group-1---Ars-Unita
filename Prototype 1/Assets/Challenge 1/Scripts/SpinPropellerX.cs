using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float speed = 100f; // kecepatan putar (derajat per detik)

    void Update()
    {
        // Putar objek di sumbu Z setiap frame
        transform.Rotate(0, 0, speed * Time.deltaTime);
    }
}