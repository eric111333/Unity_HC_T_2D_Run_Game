using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    /// <summary>
    /// 切換場景
    /// </summary>
    private void ChangeScene()
    {
        //場景管理.載入場景("場景名稱")
        SceneManager.LoadScene("遊戲場景");
    }
    /// <summary>
    /// 離開遊戲
    /// </summary>
    private void Quit()
    {
        Application.Quit();
    }
    //延遲呼叫方法
    public void DelayChangScene()
    {
        Invoke("ChangeScene", 0.5f);
    }

    public void DelayQuit()
    {
        Invoke("Quit", 0.5f);
    }
}
