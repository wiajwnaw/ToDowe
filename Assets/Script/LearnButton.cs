using UnityEngine;

using System.Collections;

using UnityEngine.UI;

using UnityEngine.EventSystems;

public class LearnButton : Button

{



    protected override void DoStateTransition(SelectionState state, bool instant)

    {

        base.DoStateTransition(state, instant);

        switch (state)

        {

            case SelectionState.Disabled:

                break;

            case SelectionState.Highlighted:

                Debug.Log("鼠标移到button上！");

                break;

            case SelectionState.Normal:

                Debug.Log("鼠标离开Button！");

                break;

            case SelectionState.Pressed:

                break;

            default:

                break;

        }

    }

}