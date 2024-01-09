using UnityEngine;
using TMPro;
public class Userdata : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI UserID;
    // Start is called before the first frame update

    string ID = "aaa";  //データベースからもらってくる

    void Start()
    {
        UserID.text = "ID:"+ID;
    }
}
