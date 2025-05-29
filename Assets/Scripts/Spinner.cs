using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xRotate = 0f;
    [SerializeField] float yRotate = 1f;
    [SerializeField] float zRotate = 0f;

    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(xRotate, yRotate, zRotate);
    }
}
