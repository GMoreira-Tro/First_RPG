using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TurnHud : MonoBehaviour
{
    //Tempo de espera entre trocas de tela
    public const float timeStep = 1;

    public GameObject normalContent;
    public GameObject skillContent;
    public GameObject diceFeedbackContent;
    public GameObject tapCardContent;

    private Player player;
    private TextMeshProUGUI diceFCTextMP;
    private TextMeshProUGUI tapCCTextMP;

    //private CardsStack cardsStack;
    //private CardsStack discardStack;

    //Não sei se vou usar ainda
    /*private void Start()
    {
        cardsStack = GameObject.Find("CardsStack").GetComponent<CardsStack>();
        discardStack = GameObject.Find("DiscardStack").GetComponent<CardsStack>();
    }*/

    public void InitializeTurnHud(Player player)
    {
        this.player = player;

        if(player.transform.position.y < 3.5)
            gameObject.transform.localPosition = new Vector3(0,6,0);
        else
            gameObject.transform.localPosition = new Vector3(0,-6.5f, 0);

        gameObject.transform.localScale = new Vector2(2, 1);

        var textMP = gameObject.GetComponentInChildren<TextMeshProUGUI>();
        diceFCTextMP = diceFeedbackContent.GetComponentInChildren<TextMeshProUGUI>();
        tapCCTextMP = tapCardContent.GetComponentInChildren<TextMeshProUGUI>();

        switch (player.classe)
        {
            case Classe.Mago:
                textMP.text = "A magia prevalecerá!";
                break;
            case Classe.Ladino:
                textMP.text = "Silencioso e mortal!";
                break;
            case Classe.Druida:
                textMP.text = "O druida comanda a selva!";
                break;
            default:
                textMP.text = "LOTKAR OGAR!";
                break;
        }
    }
    private void RollDiceToWalk()
    {
        player.passos = GameManager.D6Roll();
    }

    public void EndTurn()
    {
        PlayerTurn.EndPlayerTurn();
    }

    public void TapSkillCard()
    {

        if(player.habilidades.Count < player.habilitiesSlot)
        {
            var cardsStack = GameObject.Find("CardsStack").GetComponent<CardsStack>();
            var GO = cardsStack.DrawSkillCard(player);
        }
    }

    public void DiceRollToWalk()
    {
        StartCoroutine(DiceRollToWalkCoroutine());
    }
    private IEnumerator DiceRollToWalkCoroutine()
    {
        normalContent.SetActive(false);
        int diceNumber = GameManager.D6Roll();

        diceFeedbackContent.SetActive(true);
        diceFCTextMP.text = "Ganhaste " + diceNumber + " passos!";

        yield return new WaitForSeconds(timeStep);

        player.passos = diceNumber;

        diceFeedbackContent.SetActive(false);
        normalContent.SetActive(true);

        StartCoroutine(player.GetComponent<PlayerTurn>().UpdatePlayerPosition());
    }

    private IEnumerator TapCardCoroutine()
    {
        yield return new WaitForSeconds(timeStep);
    }
}
