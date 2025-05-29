using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 2f;

    MeshRenderer dropperMeshRenderer;
    Rigidbody dropperRigidBody;

    void Start()
    {
        dropperMeshRenderer = GetComponent<MeshRenderer>();
        dropperRigidBody = GetComponent<Rigidbody>();

        dropperMeshRenderer.enabled = false;
        dropperRigidBody.useGravity = false;
    }

    void Update()
    {
        if (Time.time > timeToWait)
        {
            Debug.Log("look up!");
            dropperMeshRenderer.enabled = true;
            dropperRigidBody.useGravity = true;
        }
    }
}
