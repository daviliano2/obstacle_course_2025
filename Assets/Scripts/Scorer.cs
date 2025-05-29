using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    void OnCollisionEnter(Collision collision)
    {
        // print(hits);
        if (!collision.gameObject.CompareTag("Hit"))
        {
            hits++;
            Debug.Log("you've bumped into something " + hits + " times");
        }
    }
}
