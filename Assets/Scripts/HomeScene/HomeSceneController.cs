using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// ホームシーンの制御を行うクラス
/// </summary>
public class HomeSceneController : MonoBehaviour
{
    // スタートボタン
    [SerializeField] private Button startButton;

    private void Start()
    {
        // スタートボタンのクリックイベントにLoadStageSelectSceneメソッドを追加
        startButton.onClick.AddListener(LoadStageSelectScene);
    }

    /// <summary>
    /// StageSelectSceneを読み込む
    /// </summary>
    private void LoadStageSelectScene()
    {
        SceneManager.LoadScene("StageSelectScene");
    }
}
