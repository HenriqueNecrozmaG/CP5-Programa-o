using UnityEngine;

public class RotatePokemon : MonoBehaviour
{
    AudioSource aus;

    void Start()
    {
        aus = GetComponent<AudioSource>();
    }

    [SerializeField] private float rotationSpeed;
    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);

        if (Input.GetButtonDown("Fire1"))
        {
            aus.Play();
            print("Som");
        }
    }

}
