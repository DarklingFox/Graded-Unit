using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//learnd to do heath code from (BMo, 2022)

public class HealthManager : MonoBehaviour
{
    //add veriables
    public int CurrentHealth, MaxHealth;
    public GameObject HealthbarPrefab;

    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth - 10;
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
        HealthbarPrefab.GetComponent<Health>().SetSprite((Health.CurrentHealthStage)CurrentHealth);

        //this large bit of code from earlier attempt
        //this is to set redraw when teke damege Health
        //if (CurrentHealth == 0 )
        //{
        //    //GameObject newHealthbar = Instantiate(HealthbarPrefab);
        //    //newHealthbar.transform.SetParent(transform);

        //    //Health HealthComponent = newHealthbar.GetComponent<Health>();
        //    //HealthComponent.SetSprite(Health.CurrentHealthStage.Health0);
        //    HealthbarPrefab.GetComponent<Health>().SetSprite((Health.CurrentHealthStage)CurrentHealth);
        //    //HealthList.Add(HealthComponent);
        //}

        //else if (CurrentHealth == 1)
        //{
        //    GameObject newHealthbar = Instantiate(HealthbarPrefab);
        //    newHealthbar.transform.SetParent(transform);

        //    Health HealthComponent = newHealthbar.GetComponent<Health>();
        //    HealthComponent.SetSprite(Health.CurrentHealthStage.Health1);
        //    HealthList.Add(HealthComponent);
        //}

        //else if (CurrentHealth == 2)
        //{
        //    GameObject newHealthbar = Instantiate(HealthbarPrefab);
        //    newHealthbar.transform.SetParent(transform);

        //    Health HealthComponent = newHealthbar.GetComponent<Health>();
        //    HealthComponent.SetSprite(Health.CurrentHealthStage.Health2);
        //    HealthList.Add(HealthComponent);
        //}

        //else if (CurrentHealth == 3)
        //{
        //    GameObject newHealthbar = Instantiate(HealthbarPrefab);
        //    newHealthbar.transform.SetParent(transform);

        //    Health HealthComponent = newHealthbar.GetComponent<Health>();
        //    HealthComponent.SetSprite(Health.CurrentHealthStage.Health3);
        //    HealthList.Add(HealthComponent);
        //}

        //else if (CurrentHealth == 4)
        //{
        //    GameObject newHealthbar = Instantiate(HealthbarPrefab);
        //    newHealthbar.transform.SetParent(transform);

        //    Health HealthComponent = newHealthbar.GetComponent<Health>();
        //    HealthComponent.SetSprite(Health.CurrentHealthStage.Health4);
        //    HealthList.Add(HealthComponent);
        //}

        //else if (CurrentHealth == 5)
        //{
        //    GameObject newHealthbar = Instantiate(HealthbarPrefab);
        //    newHealthbar.transform.SetParent(transform);

        //    Health HealthComponent = newHealthbar.GetComponent<Health>();
        //    HealthComponent.SetSprite(Health.CurrentHealthStage.Health5);
        //    HealthList.Add(HealthComponent);
        //}

        //else if (CurrentHealth == 6)
        //{
        //    GameObject newHealthbar = Instantiate(HealthbarPrefab);
        //    newHealthbar.transform.SetParent(transform);

        //    Health HealthComponent = newHealthbar.GetComponent<Health>();
        //    HealthComponent.SetSprite(Health.CurrentHealthStage.Health6);
        //    HealthList.Add(HealthComponent);
        //}

        //else if (CurrentHealth == 7)
        //{
        //    GameObject newHealthbar = Instantiate(HealthbarPrefab);
        //    newHealthbar.transform.SetParent(transform);

        //    Health HealthComponent = newHealthbar.GetComponent<Health>();
        //    HealthComponent.SetSprite(Health.CurrentHealthStage.Health7);
        //    HealthList.Add(HealthComponent);
        //}

        //else if (CurrentHealth == 8)
        //{
        //    GameObject newHealthbar = Instantiate(HealthbarPrefab);
        //    newHealthbar.transform.SetParent(transform);

        //    Health HealthComponent = newHealthbar.GetComponent<Health>();
        //    HealthComponent.SetSprite(Health.CurrentHealthStage.Health8);
        //    HealthList.Add(HealthComponent);
        //}

        //else if (CurrentHealth == 9)
        //{
        //    //GameObject newHealthbar = Instantiate(HealthbarPrefab);
        //    //newHealthbar.transform.SetParent(transform);

        //    //Health HealthComponent = newHealthbar.GetComponent<Health>();
        //    //HealthComponent.SetSprite(Health.CurrentHealthStage.Health9);
        //    //HealthList.Add(HealthComponent);
        //}

        //else if (CurrentHealth == 10)
        //{
        //    //GameObject newHealthbar = Instantiate(HealthbarPrefab);
        //    //newHealthbar.transform.SetParent(transform);

        //    //Health HealthComponent = newHealthbar.GetComponent<Health>();
        //    //HealthComponent.SetSprite(Health.CurrentHealthStage.Health10);
        //    //HealthList.Add(HealthComponent);
        //    HealthbarPrefab.GetComponent<Health>().SetSprite((Health.CurrentHealthStage)CurrentHealth);
        //}


    }

    public float DealDamage(int Amount)
    {
        // damege calculation
        CurrentHealth = CurrentHealth + Amount;

        return CurrentHealth;

    }

//When Collides with Rocket
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Projectille"))
        {
            DealDamage(1);      
        }

    }
}
