using UnityEngine;
using UnityEngine.UI;

public class AttackButtonManager : MonoBehaviour
{
    public Button attack1Button;
    public Button attack2Button;
    public Button attack3Button;
    public AttackPerformer attackPerformer; 
    public EnemyManager enemyManager; 

    private void Start()
    {
        
        attack1Button.onClick.AddListener(() =>
        {
            SetAttackStrategy(new Attack1());
            ActivateEnemy(0);
        });

        attack2Button.onClick.AddListener(() =>
        {
            SetAttackStrategy(new Attack2());
            ActivateEnemy(1);
        });

        attack3Button.onClick.AddListener(() =>
        {
            SetAttackStrategy(new Attack3());
            ActivateEnemy(2);
        });
    }

    private void SetAttackStrategy(IAttackStrategy strategy)
    {
        attackPerformer.SetStrategy(strategy);
        HighlightButton(strategy);
    }

    private void ActivateEnemy(int index)
    {
        enemyManager.ActivateEnemy(index);
        HighlightButton(index);
    }

    private void HighlightButton(IAttackStrategy strategy)
    {
        
        ResetButtonHighlights();

        if (strategy is Attack1) attack1Button.GetComponent<Image>().color = Color.yellow;
        else if (strategy is Attack2) attack2Button.GetComponent<Image>().color = Color.yellow;
        else if (strategy is Attack3) attack2Button.GetComponent<Image>().color = Color.yellow;
    }

    private void HighlightButton(int index)
    {
       
        ResetButtonHighlights();

     
        if (index == 0) attack1Button.GetComponent<Image>().color = Color.yellow;
        else if (index == 1) attack2Button.GetComponent<Image>().color = Color.yellow;
        else if (index == 2) attack3Button.GetComponent<Image>().color = Color.yellow;
    }

    private void ResetButtonHighlights()
    {
        attack1Button.GetComponent<Image>().color = Color.white;
        attack2Button.GetComponent<Image>().color = Color.white;
        attack3Button.GetComponent<Image>().color = Color.white;
    }
}