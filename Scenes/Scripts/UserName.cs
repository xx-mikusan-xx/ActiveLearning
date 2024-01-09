using UnityEngine;
using TMPro;
public class Username : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI UserName;
    // Start is called before the first frame update
    string name = "aaa";    //データベースからもらってくる

    void Start()
    {
        UserName.text = "なまえ:"+name;
    }
}
