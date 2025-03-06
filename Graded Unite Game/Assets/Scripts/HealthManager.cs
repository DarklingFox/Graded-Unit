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
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void createHealth()
    {
        GameObject newHealthbar = Instantiate(HealthbarPrefab);
        newHealthbar.transform.SetParent(transform);

        Health HealthComponent = newHealthbar.GetComponent<Health>();
        HealthComponent.SetSprite(Healthleft.Health10);
        HealthList.Add(HealthComponent);
    }
}
