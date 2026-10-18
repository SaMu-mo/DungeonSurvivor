using UnityEngine;
using TMPro;

public class GemManager : MonoBehaviour
{
    public static GemManager instance;
    public TextMeshProUGUI gemText;
    private int gems = 0;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        UpdateText();
    }

    public void AddGem()
    {
        gems++;
        UpdateText();
    }

    void UpdateText()
    {
        gemText.text = "Gemas: " + gems;
    }
}