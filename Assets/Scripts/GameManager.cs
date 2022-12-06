using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score;
    public int volume;
    public Player player;
    public Text scoreText;
    public AudioSource dieSound;
    public GameObject gameOver;
    public GameObject pauseMenu;
    public GameObject pauseButton;
    public GameObject playButton;
    public GameObject settingsButton;
    public GameObject settingsMenu;
    public GameObject quitGame;

    private void Awake() { Application.targetFrameRate = 60; }
    public void SoundOnOff(int volume) { AudioListener.volume = volume; }
    public void QuitGame() { Application.Quit(); }
    public void Exit() { SceneManager.LoadScene(0); Time.timeScale = 1; }
    public void Settings() { settingsMenu.SetActive(true); }
    public void Pause() { Time.timeScale = 0; pauseMenu.SetActive(true); }
    public void Resume() { Time.timeScale = 1; pauseMenu.SetActive(false); }
    public void CloseAd() { SceneManager.LoadScene(1); Time.timeScale = 0; score = 0; }
    public void IncreaseScore() { score++; scoreText.text = score.ToString(); }

    public void Play()
    {
        SceneManager.LoadScene(Random.Range(2,10)); //reklamlarý kapamak için 1 yapýnýz. // switch to 1 for close the ads.
        Time.timeScale = 1;
        AudioListener.volume = 1;
    }

    public void GameOver()
    {
        dieSound.Play();
        pauseButton.SetActive(false);
        playButton.SetActive(true);
        gameOver.SetActive(true);
        Time.timeScale = 0;
    }
}
