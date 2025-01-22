using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float fallSpeed = 3f;

    void Update()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);
        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Player와 Enemy 충돌함: " );

        if (collision.gameObject.layer == 6) 
        {
            // 플레이어와 충돌 시 블록 파괴
            Destroy(gameObject);
        }
    }
}