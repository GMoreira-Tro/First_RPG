using UnityEngine;
using UnityEngine.UI;

public class HowToPlayTexts : MonoBehaviour
{
    public Text text;
    public AudioSource buttonsAudio;

    private string[] stringArray = new string[3];
    private int activeStringIndex = 0;

    private void Start()
    {
        stringArray[0] = "1. Cada jogador sorteia uma carta da pilha de cartas “classe” no começo do jogo," +
            " que proporciona uma vantagem, e recebe duas cartas 'habilidade'." +
            " Lembrando que sua mochila tem um limite apenas para duas cartas 'habilidade' e 3 fichas " +
            "missão'." + "\n\n" +
            "2.Os jogadores podem se movimentar utilizando um d6.Cada um joga uma vez.No seu turno, o " +
            "jogador pode comprar uma carta “habilidade” se estiver com menos de uma carta permitida.";

        stringArray[1] = "3.O objetivo do jogo é recolher três fichas 'missão' de símbolo igual espalhadas " +
            "pelo mapa. Elas podem ser recolhidas apenas alcançando o quadrado onde estão, ali podem ser " +
            "desviradas e o jogador decide se quer levá-la na mochila. Lembrando que ele possui apenas três " +
            "espaços para fichas “missão” " + "\n\n" +
            "4.Durante o jogo os participantes podem usar cartas 'habilidade' para impulsioná-los a " +
            "vitória ou afundar outros jogadores. Apenas 2 cartas são permitidas em equipamentos." +
            "Elas podem ser utilizadas somente no turno do jogador ou, ainda, para se defender de " +
            "ataques de outros participantes.";

        stringArray[2] = "5.A efetividade das cartas é decidida através de um d6.O número tirado é " +
            "comparado com o valor de dificuldade daquela habilidade apresentado na carta.É necessário " +
            "que se tire um valor igual ou acima do que está registrado na carta." + "\n\n" +
            "6.Após encontrar as três fichas 'missão' com símbolos iguais o jogador deve ser o primeiro a chegar " +
            "na taverna a salvo com as fichas em segurança." + "\n\n" +
            "Detalhes: negócios entres jogadores são permitidos, assim como blefes e roubos, se ninguém " +
            "viu nunca aconteceu." +
            "As cartas 'habilidade' depois de usadas vão para a pilha de descarte." +
            "Se o jogador for pego roubando ele deve se redimir, doando suas cartas 'habilidade'.";
    }
    public void NextText()
    {
        if (activeStringIndex >= stringArray.Length - 1)
            return;

        activeStringIndex++;
        text.text = stringArray[activeStringIndex];
        buttonsAudio.Play();
    }

    public void PreviousText()
    {
        if (activeStringIndex == 0)
            return;

        activeStringIndex--;
        text.text = stringArray[activeStringIndex];
        buttonsAudio.Play();
    }
}
