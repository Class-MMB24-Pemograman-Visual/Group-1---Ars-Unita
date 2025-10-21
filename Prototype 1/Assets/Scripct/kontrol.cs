using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public float moveSpeed = 5f;   // kecepatan maju
    public float turnSpeed = 100f; // kecepatan belok

    void Update()
    {
        // Tombol W/S atau ↑/↓ buat maju mundur
        float move = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        // Tombol A/D atau ←/→ buat belok
        float turn = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        // Gerak maju/mundur
        transform.Translate(0, 0, move);

        // Rotasi kiri/kanan
        transform.Rotate(0, turn, 0);
    }
}