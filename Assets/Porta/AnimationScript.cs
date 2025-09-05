using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PortaController_XRIT : MonoBehaviour
{
    // Crie uma refer�ncia para o Animator da porta
    public Animator portaAnimator;

    // Mensagem do Unity 0 refer�ncias
    private void Start()
    {
        // Certifique-se de que a refer�ncia ao Animator n�o est� vazia
        if (portaAnimator == null)
        {
            Debug.LogError("O Animator da porta n�o foi atribu�do no Inspector.");
        }
    }

    // A nova fun��o p�blica que o bot�o vai chamar
    public void AbrirPorta()
    {
        if (portaAnimator != null)
        {
            portaAnimator.SetTrigger("Open");
        }
    }
}