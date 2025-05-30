using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject[] projectiles;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            foreach (GameObject projectile in projectiles)
            {
                // If the trigger is called twice then we get an error in the console
                // This is probably a workaround and not the right solution
                // if (projectile != null)
                // {
                //     projectile.SetActive(true);
                // }

                projectile.SetActive(true);
                Destroy(gameObject);
            }
        }
    }
}
