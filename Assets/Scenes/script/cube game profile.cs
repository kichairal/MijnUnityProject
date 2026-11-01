using UnityEngine;
using System.Collections;

public class BallShooter : MonoBehaviour
{
    public Vector3 initialVelocity = new Vector3(8f, 0f, 0f);

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.linearVelocity = initialVelocity;
    }
}

public class ExampleClass : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }
        if (collision.relativeVelocity.magnitude > 2)
            audioSource.Play();
    }
}