using UnityEngine;

public class EndGame : MonoBehaviour
{
    public bool isGameLost = false;
    public bool isGameWon = false;
    private float health = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void GameOver()
    {
        if (health == 0)
        {
            isGameLost = true;
            showLossScreen();
        }
    }
    
    public void showLossScreen()
    {

    }
    public void showWinScreen()
    {

    }
}
