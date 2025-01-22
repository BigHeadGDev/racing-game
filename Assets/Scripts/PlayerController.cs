using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    private void Update()
    {
        float horizontalInput = 0f;

        if (Input.GetKey(KeyCode.A))
        {
            horizontalInput = 1f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            horizontalInput = -1f;
        }

        Vector3 movement = new Vector3(0, 0, horizontalInput * speed * Time.deltaTime);
        transform.Translate(movement);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.layer == 7)
        {
            Debug.Log("벽충돌");
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("충돌 감지: " + collision.gameObject.layer); // 충돌한 오브젝트의 레이어 출력

        if (collision.gameObject.layer == 7) // 에너미 레이어 번호 7
        {
            // 뒤로 밀려나는 효과 (y축 아래로 이동)
            Debug.Log("Enemy와 충돌함");
            transform.position -= new Vector3(0, 1f, 0);
        }
        else if (collision.gameObject.layer == 8) // 오일 레이어 번호 8
        {
            // 앞으로 전진하는 효과 (y축 위로 이동)
            Debug.Log("Oil과 충돌함");
            transform.position += new Vector3(0, 1f, 0);
        }
    }
}