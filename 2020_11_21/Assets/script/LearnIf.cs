using UnityEngine;

public class LearnIf : MonoBehaviour
{
    public bool isOpen;
    public int score = 100;

    private void Start()
    {
        if (true)
        {
            print("當布林值為true會執行此敘述。");
        }
    }

    // 更新事件:一秒值行約60次
    private void Update()
    {
        if (isOpen)
        {
            print("開門");
        }
        else
        {
            print("關門");
        }

        if(score >= 60)
        {
            print("及格");
        }
        else if (score>=40)
        {
            print("補考");
        }
        else
        {
            print("當掉");
        }
    }




}
