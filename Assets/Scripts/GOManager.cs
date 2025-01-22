using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GOManager : MonoBehaviour
{
    public Button restartButton;  

    public GameObject gameOverPanel; // 게임 오버 패널 오브젝트를 할당할 변수

    void Start()
    {
        gameOverPanel.SetActive(false); 
        restartButton.onClick.AddListener(RestartGame);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            gameOverPanel.SetActive(true);  
            Time.timeScale = 0;  

        }
    }
    void RestartGame()
    {
        Time.timeScale = 1; 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  
    }
}