using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChoiceList : MonoBehaviour
{
    public Transform parent;
    public GameObject listItem;

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
        List<ChoiceData> situationDatas = GetXmlManager().choiceDatas;
        string cur_key = FindObjectOfType<SaveHandler>().CUR_SITU_KEY;
        foreach (ChoiceData data in situationDatas) {
            if(data.situation_key == cur_key)
            {
                GameObject item = Instantiate(listItem, parent);
                item.GetComponent<ListItemChoice>().SetData(data);
            }
        }
    }
}
