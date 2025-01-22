using UnityEngine;

public class Oil : MonoBehaviour
{
    public float fallSpeed = 3f;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.layer == 6) // 플레이어 레이어 번호 6
        {
            // 플레이어와 충돌 시 블록 파괴
            Debug.Log("Player와 Oil 충돌함: " + gameObject.layer);
            Destroy(gameObject);
        }
    } 
    void Update()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);
        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }

    
}