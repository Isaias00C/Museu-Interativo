using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PortaController_XRIT : MonoBehaviour
{
    // Crie uma referência para o Animator da porta
    public Animator portaAnimator;

    // Mensagem do Unity 0 referências
    private void Start()
    {
        // Certifique-se de que a referência ao Animator não está vazia
        if (portaAnimator == null)
        {
            Debug.LogError("O Animator da porta não foi atribuído no Inspector.");
        }
    }

    // A nova função pública que o botão vai chamar
    public void AbrirPorta()
    {
        if (portaAnimator != null)
        {
            portaAnimator.SetTrigger("Open");
        }
    }
}