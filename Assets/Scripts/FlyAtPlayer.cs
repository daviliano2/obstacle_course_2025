using TMPro;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float speed = 0.1f;
    [SerializeField] Transform player;
    Vector3 playerPosition;

    void Awake()
    {
        gameObject.SetActive(false);
    }

    void Start()
    {
        playerPosition = player.transform.position;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);

        if (transform.position == playerPosition)
        {
            DestroyWhenReached();
        }
    }

    void DestroyWhenReached()
    {
        Destroy(gameObject);
    }
}
