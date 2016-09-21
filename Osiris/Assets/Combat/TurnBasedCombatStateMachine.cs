using UnityEngine;
using System.Collections;

public class TurnBasedCombatStateMachine : MonoBehaviour {

    public enum BattleStates
    {
        START,
        PLAYER_CHOICE,
        ENEMY_CHOICE,
        LOSE,
        WIN
    }

    private BattleStates currentState;

	void Start () {
        currentState = BattleStates.START;
	}

	void Update () {
        Debug.Log(currentState);
        switch (currentState)
        {
            case BattleStates.START:
                // SET UP BATTLE
                break;
            case BattleStates.PLAYER_CHOICE:
                // PROVIDE OPTIONS
                break;
            case BattleStates.ENEMY_CHOICE:
                break;
            case BattleStates.LOSE:
                break;
            case BattleStates.WIN:
                break;
        }
	}
}
