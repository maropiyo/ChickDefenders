using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// タイトルシーンの制御を行うクラス
/// </summary>
public class TitleSceneController : MonoBehaviour
{
    // スタートボタン
    [SerializeField] private Button startButton;

    private void Start()
    {
        // StartButtonのクリックイベントにLoadHomeSceneメソッドを追加
        startButton.onClick.AddListener(LoadHomeScene);
    }

    /// <summary>
    /// HomeSceneを読み込む
    /// </summary>
    private void LoadHomeScene()
    {
        SceneManager.LoadScene("HomeScene");
    }
}