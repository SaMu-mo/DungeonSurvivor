using UnityEngine;

public class Gem : MonoBehaviour
{
    private bool collected = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (collected) return;

        if (other.CompareTag("Player"))
        {
            collected = true;
            GemManager.instance.AddGem();
            Destroy(gameObject);
        }
    }
}