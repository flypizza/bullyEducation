using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveHandler : MonoBehaviour
{
    SituationData situationData;
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
    public SituationData CUR_SITU
    {
        get
        {
            return situationData;
        }
        set
        {
            situationData = value;
        }
    }
    ChoiceData curSelect_ChoiceData = null;
    public ChoiceData CUR_SELECT_CHOICE_DATA
    {
        get
        {
            return curSelect_ChoiceData;
        }
        set
        {
            curSelect_ChoiceData = value;
        }
    }

}
