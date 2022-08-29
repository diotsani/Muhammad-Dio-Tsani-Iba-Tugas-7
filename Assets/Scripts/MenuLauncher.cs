using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.U2D;
using UnityEngine.UI;

public class MenuLauncher : MonoBehaviour
{
    [SerializeField] private Button _playAudioButton;
    [SerializeField] private Button _playNoAudioButton;
    [SerializeField] private SpriteAtlas _atlas;
    [SerializeField] private Image[] _buttonImage;
    // Start is called before the first frame update
    private void Awake()
    {
        _buttonImage[0].sprite = _atlas.GetSprite("Blue gradient");
        _buttonImage[1].sprite = _atlas.GetSprite("Red gradient");
    }
    void Start()
    {
        _playAudioButton.onClick.RemoveAllListeners();
        _playNoAudioButton.onClick.RemoveAllListeners();
        _playAudioButton.onClick.AddListener(OnWithAudioButtonClicked);
        _playNoAudioButton.onClick.AddListener(OnWithoutAudioButtonClicked);
    }
    private void OnWithAudioButtonClicked()
        {
            
            AudioManager.Instance.isAudioEnabled = true;
            SceneManager.LoadScene("Game");
        }
        private void OnWithoutAudioButtonClicked()
        {
            
            AudioManager.Instance.isAudioEnabled = false;
            SceneManager.LoadScene("Game");
        }
}
