using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    //add veriables
    public float CurrentHealth, MaxHealth;
    public GameObject HealthbarPrefab;
    List<Health> HealthList = new List<Health>();

    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth;

        //Call Method
        DrawHeath();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Display current Health
    public void DrawHeath()
    {
        float MaxHealthRemainder = MaxHealth % 2;
        int HealthCreated = (int)((MaxHealth / 2) + MaxHealthRemainder);

        createHealth();
        
        int HealtheRemainder = (int)Mathf.Clamp(CurrentHealth - (1 * 2), 0, 10);
        
    }

    // Create Health bar for Player and Enemy
    public void createHealth()
    {
        GameObject newHealthbar = Instantiate(HealthbarPrefab);
        newHealthbar.transform.SetParent(transform);

        Health HealthComponent = newHealthbar.GetComponent<Health>();
        HealthComponent.SetSprite(Health.CurrentHealthStage.Health10);
        HealthList.Add(HealthComponent);
    }

    public void DealDamage(float Amount)
    {
        CurrentHealth = CurrentHealth - Amount;

    }

//When Collides with Rocket
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Rocket")
        {
             DealDamage(1);
        }

    }
}
