using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Image healthBar;
    public int maxHealth = 10;
    public int health;
    

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
       
    }
    

    public void TakeDamage(int damage)
    {
        health -= damage;
        healthBar.fillAmount =(float) health / maxHealth;
        if(health <= 0)
        {
            Destroy(gameObject);
            
            SceneManager.LoadScene("mainmenu");
        }
    }
    public void Healing(int heal)
    {
        health += heal;
        if(health > maxHealth)
        {
            health = maxHealth;
        }
        healthBar.fillAmount = (float)health / maxHealth;
    }
   
}
