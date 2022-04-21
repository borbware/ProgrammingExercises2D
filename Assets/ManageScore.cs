using UnityEngine;

public class ManageScore : MonoBehaviour
{
    public static ManageScore instance;
    public int score = 0;
    [SerializeField] UI _ui;
    int levelPhase = 0;
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

    private void Update()
    {
        if (score % 20 == 0 && score > 0 && levelPhase != score)
        {
            levelPhase = score;
            Debug.Log(score);
        }
    }
}
