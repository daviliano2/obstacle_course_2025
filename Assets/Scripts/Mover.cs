using UnityEngine;

public class Mover : MonoBehaviour
{
    // when we serialize a var we can access to it in unity
    [SerializeField] float moveSpeed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintIntruction();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintIntruction()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move using the arrow keys or AWSD");
        Debug.Log("Avoid bumping into the obstacles");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, yValue, zValue);
    }
}
