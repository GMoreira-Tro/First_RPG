using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TurnHud : MonoBehaviour
{
    public GameObject normalContent;
    public GameObject skillContent;
    public GameObject diceFeedbackContent;
    public GameObject tapCardContent;

    private Player player;
    private TextMeshProUGUI diceFCTextMP;
    private TextMeshProUGUI tapCCTextMP;

    /// <summary>
    /// Tempo de espera entre trocas de tela
    /// </summary>
    private const float timeStep = 1;
    /// <summary>
    /// Tempo em segundos para atualizar a posição do personagem
    /// </summary>
    private const float walkStep = 0.4f;

    //private CardsStack cardsStack;
    //private CardsStack discardStack;

    //Não sei se vou usar ainda
    private void Start()
    {
        //cardsStack = GameObject.Find("CardsStack").GetComponent<CardsStack>();
        //discardStack = GameObject.Find("DiscardStack").GetComponent<CardsStack>();
        StartCoroutine(ToggleHudCoroutine(true));
    }

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
            try {
                var habilidade = cardsStack.DrawSkillCard(player);
                tapCCTextMP.text = "Ganhaste a habilidade: ";

                var card = Instantiate(habilidade, tapCardContent.transform);
                card.transform.localScale = new Vector2(0.6f, 0.6f);
                card.transform.localPosition = new Vector3(0, 0, 0);
            }
            catch (System.Exception)
            {
                tapCCTextMP.text = "Não há mais cartas de habilidade para comprar!";
                tapCCTextMP.transform.localPosition += new Vector3(3, 0, 0);
            }
        }
        else
        {
            tapCCTextMP.text = "Não possues mais espaço para cartas habilidades!";
            tapCCTextMP.transform.localPosition += new Vector3 (3,0,0);
        }

        StartCoroutine(TapCardCoroutine());
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

        StartCoroutine(UpdatePlayerPosition());
    }

    private IEnumerator TapCardCoroutine()
    {
        normalContent.SetActive(false);
        tapCardContent.SetActive(true);

        yield return new WaitForSeconds(timeStep);

        normalContent.SetActive(true);
        tapCardContent.SetActive(false);
    }

    /// <summary>
    /// Coroutina para atualizar a posição do Player, de acordo com os direcionais W,A,S,D clicados
    /// </summary>
    /// <returns></returns>
    public IEnumerator UpdatePlayerPosition()
    {
        while (player.passos > 0)
        {
            if (Input.GetKey(KeyCode.D))
            {
                player.gameObject.transform.position += new Vector3(2, 0, 0);
                player.passos--;

                if (player.transform.position.y > 3.5)
                    gameObject.transform.localPosition = new Vector3(0, -6.5f, 0);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                player.gameObject.transform.position += new Vector3(-2, 0, 0);
                player.passos--;

                if (player.transform.position.y > 3.5)
                    gameObject.transform.localPosition = new Vector3(0, -6.5f, 0);
            }
            else if (Input.GetKey(KeyCode.W))
            {
                player.gameObject.transform.position += new Vector3(0, 0.82f, 0);
                player.passos--;

                if (player.transform.position.y > 3.5)
                    gameObject.transform.localPosition = new Vector3(0, -6.5f, 0);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                player.gameObject.transform.position += new Vector3(0, -0.82f, 0);
                player.passos--;

                if (player.transform.position.y > 3.5)
                    gameObject.transform.localPosition = new Vector3(0, -6.5f, 0);
            }

            yield return new WaitForSeconds(walkStep);
        }
    }

    private IEnumerator ToggleHudCoroutine(bool turnInvisible)
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (turnInvisible)
            {
                gameObject.transform.position += new Vector3(0, 100, 0);
            }
            else
            {
                gameObject.transform.position += new Vector3(0, -100, 0);
            }
            turnInvisible = !turnInvisible;
        }
        yield return new WaitForSeconds(0.5f);

        StartCoroutine(ToggleHudCoroutine(turnInvisible));
    }
}
