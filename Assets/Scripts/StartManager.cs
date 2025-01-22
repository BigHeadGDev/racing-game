using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StartManager : MonoBehaviour
{
    public GameObject panel;  
    public Button startButton;  
    public GameObject spawnObject;  

    void Start()
    {
        startButton.onClick.AddListener(OnStartButtonClicked);  
        panel.SetActive(true);  
        spawnObject.SetActive(false);
    }

    void OnStartButtonClicked()
    {
        panel.SetActive(false);  
        spawnObject.SetActive(true);
    }

}