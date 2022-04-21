using UnityEngine;

public class ManageScore : MonoBehaviour
{
    public static ManageScore instance;
    [SerializeField] int score = 0;
    [SerializeField] UI _ui;
    void Start()
    {
        if (instance != null) // to be sure there is only one ManageScore
            instance.gameObject.SetActive(false);
        instance = this;
    }

    public void AddToScore(int newScore)
    {
        score += newScore;
        _ui.setScore(score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
