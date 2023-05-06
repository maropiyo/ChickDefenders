using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// ステージ選択シーンの制御を行うクラス
/// </summary>
public class StageSelectSceneController : MonoBehaviour
{
    // ゲームスタートボタン
    [SerializeField] private Button gameStartButton;

    private void Start()
    {
        // スタートボタンのクリックイベントにLoadGameSceneメソッドを追加
        gameStartButton.onClick.AddListener(LoadGameScene);
    }

    /// <summary>
    /// GameSceneを読み込む
    /// </summary>
    private void LoadGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
