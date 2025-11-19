using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public Text crystalText;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        UpdateCrystalText(0);
    }

    public void UpdateCrystalText(int amount)
    {
        crystalText.text = "Crystals: " + amount;
    }
}
