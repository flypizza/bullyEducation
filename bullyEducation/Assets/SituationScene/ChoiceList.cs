using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChoiceList : MonoBehaviour
{
    public Transform parent;
    public GameObject listItem;
    public Text txt_situation;
    // Start is called before the first frame update
    void Start()
    {
        SetList();
    }

    XmlManager xmlManager = null;
    public XmlManager GetXmlManager()
    {
        if (xmlManager == null)
        {
            xmlManager = FindObjectOfType<XmlManager>();
        }
        return xmlManager;
    }
    public void SetList() {
        SituationData situationData  = FindObjectOfType<SaveHandler>().CUR_SITU;
        txt_situation.text = situationData.situation;


        List<ChoiceData> situationDatas = GetXmlManager().choiceDatas;
        string cur_key = situationData.key;
        foreach (ChoiceData data in situationDatas) {
            if(data.situation_key == cur_key)
            {
                GameObject item = Instantiate(listItem, parent);
                item.GetComponent<ListItemChoice>().SetData(data);
            }
        }
    }
}
