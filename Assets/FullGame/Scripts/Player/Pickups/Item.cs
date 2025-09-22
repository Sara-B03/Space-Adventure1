using UnityEngine;

[RequireComponent (typeof(BoxCollider2D))]
public class Item : MonoBehaviour
{
    private BoxCollider2D itemCollider;

    private void Awake()
    {
        itemCollider = GetComponent<BoxCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //*if(collision.gameObject.TryGetComponent(out PlayerMovementHandler playerMovement))
        //*{
        //*    GameManager.Instance.AddScore();
        //*    Destroy(gameObject);
        //*    
        //*}
    }
}
