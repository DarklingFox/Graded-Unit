using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    //Add variables
    public Sprite Healthbar0, Healthbar1, Healthbar2, Healthbar3, Healthbar4, Healthbar5, Healthbar6, Healthbar7, Healthbar8, Healthbar9, Healthbar10;
    Image HealthSprite;

    // Start is called before the first frame update
    void Start()
    {
        HealthSprite = GetComponent<Image>();

        
    }

    // Update is called once per frame
    void Update()
    {
        //switch (CurrentHealthStage Healthleft)
        //{
            
        //}
    }

   public enum CurrentHealthStage
    {
        Healthbar0 = 0,
        Healthbar1 = 1,
        Healthbar2 = 2,
        Healthbar3 = 3,
        Healthbar4 = 4,
        Healthbar5 = 5,
        Healthbar6 = 6,
        Healthbar7 = 7,
        Healthbar8 = 8,
        Healthbar9 = 9,
        Healthbar10 = 10,
    }
}
