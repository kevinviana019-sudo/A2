using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int totalCrystals;
    public int collectedCrystals;
    public List<Crystal> crystalsCollected = new List<Crystal>();

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        
        if (scene.name == "GameScene")
        {
            Crystal[] all = FindObjectsOfType<Crystal>();
            totalCrystals = all.Length;

            collectedCrystals = 0;
            crystalsCollected.Clear();

            if (UIManager.instance != null)
            {
                UIManager.instance.UpdateCrystalText(collectedCrystals);
            }
        }
    }

    public void AddCrystal(Crystal c)
    {
        crystalsCollected.Add(c);
        collectedCrystals++;

        if (UIManager.instance != null)
            UIManager.instance.UpdateCrystalText(collectedCrystals);
    }

    public void EndGame()
    {
        SceneManager.LoadScene("MenuScene");

        collectedCrystals = 0;
        crystalsCollected.Clear();
    }
}
