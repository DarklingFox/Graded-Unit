using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//learnd to do heath code from (BMo, 2022)

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

        
    }

    // Update is called once per frame
    void Update()
    {  
        //Call Method
        DrawHeath();
    }

    //Display current Health
    public void DrawHeath()
    {
        //this is to set redraw when teke damege Health
        if (CurrentHealth == 0 )
        {
            GameObject newHealthbar = Instantiate(HealthbarPrefab);
            newHealthbar.transform.SetParent(transform);

            Health HealthComponent = newHealthbar.GetComponent<Health>();
            HealthComponent.SetSprite(Health.CurrentHealthStage.Health0);
            HealthList.Add(HealthComponent);
        }

        else if (CurrentHealth == 1)
        {
            GameObject newHealthbar = Instantiate(HealthbarPrefab);
            newHealthbar.transform.SetParent(transform);

            Health HealthComponent = newHealthbar.GetComponent<Health>();
            HealthComponent.SetSprite(Health.CurrentHealthStage.Health1);
            HealthList.Add(HealthComponent);
        }

        else if (CurrentHealth == 2)
        {
            GameObject newHealthbar = Instantiate(HealthbarPrefab);
            newHealthbar.transform.SetParent(transform);

            Health HealthComponent = newHealthbar.GetComponent<Health>();
            HealthComponent.SetSprite(Health.CurrentHealthStage.Health2);
            HealthList.Add(HealthComponent);
        }

        else if (CurrentHealth == 3)
        {
            GameObject newHealthbar = Instantiate(HealthbarPrefab);
            newHealthbar.transform.SetParent(transform);

            Health HealthComponent = newHealthbar.GetComponent<Health>();
            HealthComponent.SetSprite(Health.CurrentHealthStage.Health3);
            HealthList.Add(HealthComponent);
        }

        else if (CurrentHealth == 4)
        {
            GameObject newHealthbar = Instantiate(HealthbarPrefab);
            newHealthbar.transform.SetParent(transform);

            Health HealthComponent = newHealthbar.GetComponent<Health>();
            HealthComponent.SetSprite(Health.CurrentHealthStage.Health4);
            HealthList.Add(HealthComponent);
        }

        else if (CurrentHealth == 5)
        {
            GameObject newHealthbar = Instantiate(HealthbarPrefab);
            newHealthbar.transform.SetParent(transform);

            Health HealthComponent = newHealthbar.GetComponent<Health>();
            HealthComponent.SetSprite(Health.CurrentHealthStage.Health5);
            HealthList.Add(HealthComponent);
        }

        else if (CurrentHealth == 6)
        {
            GameObject newHealthbar = Instantiate(HealthbarPrefab);
            newHealthbar.transform.SetParent(transform);

            Health HealthComponent = newHealthbar.GetComponent<Health>();
            HealthComponent.SetSprite(Health.CurrentHealthStage.Health6);
            HealthList.Add(HealthComponent);
        }

        else if (CurrentHealth == 7)
        {
            GameObject newHealthbar = Instantiate(HealthbarPrefab);
            newHealthbar.transform.SetParent(transform);

            Health HealthComponent = newHealthbar.GetComponent<Health>();
            HealthComponent.SetSprite(Health.CurrentHealthStage.Health7);
            HealthList.Add(HealthComponent);
        }

        else if (CurrentHealth == 8)
        {
            GameObject newHealthbar = Instantiate(HealthbarPrefab);
            newHealthbar.transform.SetParent(transform);

            Health HealthComponent = newHealthbar.GetComponent<Health>();
            HealthComponent.SetSprite(Health.CurrentHealthStage.Health8);
            HealthList.Add(HealthComponent);
        }

        else if (CurrentHealth == 9)
        {
            GameObject newHealthbar = Instantiate(HealthbarPrefab);
            newHealthbar.transform.SetParent(transform);

            Health HealthComponent = newHealthbar.GetComponent<Health>();
            HealthComponent.SetSprite(Health.CurrentHealthStage.Health9);
            HealthList.Add(HealthComponent);
        }

        else if (CurrentHealth == 10)
        {
            GameObject newHealthbar = Instantiate(HealthbarPrefab);
            newHealthbar.transform.SetParent(transform);

            Health HealthComponent = newHealthbar.GetComponent<Health>();
            HealthComponent.SetSprite(Health.CurrentHealthStage.Health10);
            HealthList.Add(HealthComponent);
        }
        createHealth();
        
        //int HealtheRemainder = (int)Mathf.Clamp(CurrentHealth - (1 * 2), 0, 10);
        
    }

    // Create Health bar for Player and Enemy
    public void createHealth()
    {
        //GameObject newHealthbar = Instantiate(HealthbarPrefab);
        //newHealthbar.transform.SetParent(transform);

        //Health HealthComponent = newHealthbar.GetComponent<Health>();
        //HealthComponent.SetSprite(Health.CurrentHealthStage.Health10);
        //HealthList.Add(HealthComponent);
    }

    public void DealDamage(float Amount)
    {
        CurrentHealth = CurrentHealth + Amount;

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
