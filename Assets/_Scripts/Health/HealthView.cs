using UnityEngine;
using UnityEngine.UI;

public class HealthView : MonoBehaviour 
{
    public Text textHealth;
    private Health health;

	void Start () 
    {
        health = new Health();
        DisplayHealth();		
	}

    public void DisplayHealth()
    {
        string msg = "health = " + health.GetHealth();
        textHealth.text = msg;
    }

}
