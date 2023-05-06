using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// ステージ選択シーンの制御を行うクラス
/// </summary>
public class StageSelectSceneController : MonoBehaviour
{
    // ゲームボタン
    [SerializeField] private Button gameButton;

    private void Start()
    {
        // スタートボタンのクリックイベントにLoadDebugStageSceneメソッドを追加
        gameButton.onClick.AddListener(LoadDebugStageScene);
    }

    /// <summary>
    /// DebugStageSceneを読み込む
    /// </summary>
    private void LoadDebugStageScene()
    {
        SceneManager.LoadScene("DebugStageScene");
    }
}
