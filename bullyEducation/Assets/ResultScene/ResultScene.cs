using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ResultScene : MonoBehaviour {
    public Text txt_suc;
    public Text txt_result;

    // Start is called before the first frame update
    void Start()
    {
        UpdateUi();
    }

    public void UpdateUi() {
        ChoiceData choiceData = FindObjectOfType<SaveHandler>().CUR_SELECT_CHOICE_DATA;
        txt_result.text = choiceData.result;
        if(choiceData.suc == 1) {
            txt_suc.text = "참교육 성공";
        }
        else {
            txt_suc.text = "참교육 실패";
        }
    }
}
