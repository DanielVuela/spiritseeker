using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private AudioSource musicSource;

    void Awake()
    {
        DontDestroyOnLoad(gameObject); // Evita que la música se reinicie al cambiar de escena
        musicSource = GetComponent<AudioSource>();
    }

    public void SetVolume(float volume)
    {
        musicSource.volume = volume; // Ajusta el volumen dinámicamente
    }

    public void StopMusic()
    {
        musicSource.Stop(); // Detiene la música
    }
}
