using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] TextMeshProUGUI textComponent2;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void setScore(int newScore)
    {
        textComponent.text = $"Number of Töks: {newScore}";
        textComponent2.text = $"Number of Töks (fancy): {newScore}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
