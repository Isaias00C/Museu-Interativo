using UnityEngine;
using UnityEngine.UI; // Namespace necessário para interagir com a UI

public class ControladorMusicaToggle : MonoBehaviour
{
    // --- REFERÊNCIAS EXISTENTES ---
    // Referência pública para o AudioSource que toca a música
    public AudioSource musicaSource;
    // Referência pública para o nosso Toggle
    public Toggle musicaToggle;

    // --- NOVA REFERÊNCIA ---
    // Referência pública para o nosso Slider de volume
    public Slider volumeSlider;

    void Start()
    {
        // --- CÓDIGO DO TOGGLE (EXISTENTE) ---
        if (musicaToggle.isOn)
        {
            musicaSource.UnPause();
        }
        else
        {
            musicaSource.Pause();
        }
        musicaToggle.onValueChanged.AddListener(OnToggleValueChanged);

        // --- NOVO CÓDIGO DO SLIDER ---
        // Define o volume inicial da música com base no valor inicial do slider
        musicaSource.volume = volumeSlider.value;

        // Adiciona um "ouvinte" para o slider, que chamará a função OnVolumeSliderChanged
        volumeSlider.onValueChanged.AddListener(OnVolumeSliderChanged);
    }

    // --- FUNÇÃO DO TOGGLE (EXISTENTE) ---
    public void OnToggleValueChanged(bool isOn)
    {
        if (isOn)
        {
            musicaSource.UnPause();
        }
        else
        {
            musicaSource.Pause();
        }
    }

    // --- NOVA FUNÇÃO PARA O SLIDER ---
    // Esta função é chamada quando o valor do Slider é alterado
    public void OnVolumeSliderChanged(float valor)
    {
        // Atualiza o volume do AudioSource para ser igual ao valor do slider
        musicaSource.volume = valor;
    }
}