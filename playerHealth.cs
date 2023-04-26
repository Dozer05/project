using UnityEngine;

public class playerHealth : MonoBehaviour
{ 
    public int maxHealth = 100;
    public int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.P))
        {
            TakeDamage(20);
        }

        void TakeDamage(int damage)
        {
            currentHealth -= damage;
        }

    }
}
