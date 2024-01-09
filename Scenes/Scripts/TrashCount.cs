using UnityEngine;
using TMPro;
public class Trashcount : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI TrashCount; //捨てたごみの数を表示
    // Start is called before the first frame update
    int count = 0;    //データベースからもらってくる

    void Start()
    {
        TrashCount.text = "捨てたごみの数:"+count;
    }
}
