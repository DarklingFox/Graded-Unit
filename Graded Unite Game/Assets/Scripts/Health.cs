using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//learnd to do heath code from (BMo, 2022)
public class Health : MonoBehaviour
{
    //Add variables
    public Sprite Healthbar0, Healthbar1, Healthbar2, Healthbar3, Healthbar4, Healthbar5, Healthbar6, Healthbar7, Healthbar8, Healthbar9, Healthbar10;
    Image HealthSprite;
    SpriteRenderer renderer;
    public int StartingHealth; 

    // Start is called before the first frame update
    void Start()
    {
        //get component 
        HealthSprite = GetComponent<Image>();
        renderer = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void SetSprite(CurrentHealthStage Healthleft)
    {
        if(HealthSprite == null)
        {
            HealthSprite = gameObject.GetComponent<Image>();
        }

        //set sprite by having the int value equal correct sprite
        switch (Healthleft)
        {
            case CurrentHealthStage.Health0:
                renderer.sprite = Healthbar0;
                break;
            case CurrentHealthStage.Health1:
                renderer.sprite = Healthbar1;
                break;
            case CurrentHealthStage.Health2:
                renderer.sprite = Healthbar2;
                break;
            case CurrentHealthStage.Health3:
                renderer.sprite = Healthbar3;
                break;
            case CurrentHealthStage.Health4:
                renderer.sprite = Healthbar4;
                break;
            case CurrentHealthStage.Health5:
                renderer.sprite = Healthbar5;
                break;
            case CurrentHealthStage.Health6:
                renderer.sprite = Healthbar6;
                break;
            case CurrentHealthStage.Health7:
                renderer.sprite = Healthbar7;
                break;
            case CurrentHealthStage.Health8:
                renderer.sprite = Healthbar8;
                break;
            case CurrentHealthStage.Health9:
                renderer.sprite = Healthbar9;
                break;
            case CurrentHealthStage.Health10:
                renderer.sprite = Healthbar10;
                break;
        }
    }

   public enum CurrentHealthStage
    {
        //To give sprite an int value
        Health0 = 0,
        Health1 = 1,
        Health2 = 2,
        Health3 = 3,
        Health4 = 4,
        Health5 = 5,
        Health6 = 6,
        Health7 = 7,
        Health8 = 8,
        Health9 = 9,
        Health10 = 10,
    }
}
