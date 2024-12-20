using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] Color32 getKey = new Color32(1, 1, 1, 1);
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            spriteRenderer.color = getKey;
            //set active collider của room đó?

        }
    }
}
