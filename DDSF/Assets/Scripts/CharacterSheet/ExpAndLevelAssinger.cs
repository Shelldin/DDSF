using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpAndLevelAssinger : MonoBehaviour
{
    public CharacterSheetSO charSheet;
    public Text levelText;
    public Text expText;
    public InputField expInputField;

    private void Awake()
    {
        expInputField.onEndEdit.AddListener(AssignExpValue);
    }

    private void AssignExpValue(string playerInput)
    {
        charSheet.experience = charSheet.experience + int.Parse(playerInput);
        if (charSheet.experience < 0)
        {
            charSheet.experience = 0;
        }

        if (charSheet.experience > 355000)
        {
            charSheet.experience = 355000;
        }
        expText.text = charSheet.experience.ToString();
        expInputField.text = null;
        AssignLevelValue();
    }

    private void AssignLevelValue()
    {
        if (charSheet.experience >= 0 && charSheet.experience < 300)
        {
            charSheet.level = 1;
        }
        if (charSheet.experience >=300  && charSheet.experience <900 )
        {
            charSheet.level = 2 ;
        }
        if (charSheet.experience >=900  && charSheet.experience <2700 )
        {
            charSheet.level =3 ;
        }
        if (charSheet.experience >=2700  && charSheet.experience <6500 )
        {
            charSheet.level =4 ;
        }
        if (charSheet.experience >=6500  && charSheet.experience <14000 )
        {
            charSheet.level =5 ;
        }
        if (charSheet.experience >=14000  && charSheet.experience <23000 )
        {
            charSheet.level =6 ;
        }
        if (charSheet.experience >=23000  && charSheet.experience <34000 )
        {
            charSheet.level =7 ;
        }
        if (charSheet.experience >=34000  && charSheet.experience <48000 )
        {
            charSheet.level =8 ;
        }
        if (charSheet.experience >=48000  && charSheet.experience <64000 )
        {
            charSheet.level =9 ;
        }
        if (charSheet.experience >=64000  && charSheet.experience <85000 )
        {
            charSheet.level =10 ;
        }
        if (charSheet.experience >=85000  && charSheet.experience <100000 )
        {
            charSheet.level =11 ;
        }
        if (charSheet.experience >=100000  && charSheet.experience <120000 )
        {
            charSheet.level =12 ;
        }
        if (charSheet.experience >=120000  && charSheet.experience <140000 )
        {
            charSheet.level =13 ;
        }
        if (charSheet.experience >= 140000 && charSheet.experience < 165000)
        {
            charSheet.level =14 ;
        }
        if (charSheet.experience >= 165000 && charSheet.experience <195000 )
        {
            charSheet.level =15 ;
        }
        if (charSheet.experience >=195000  && charSheet.experience <225000 )
        {
            charSheet.level =16 ;
        }
        if (charSheet.experience >=225000  && charSheet.experience <265000 )
        {
            charSheet.level =17 ;
        }
        if (charSheet.experience >=265000  && charSheet.experience <305000 )
        {
            charSheet.level =18 ;
        }
        if (charSheet.experience >=305000  && charSheet.experience <355000 )
        {
            charSheet.level =19 ;
        }
        if (charSheet.experience >=355000)
        {
            charSheet.level =20 ;
        }

        levelText.text = charSheet.level.ToString();
    }
    
}
