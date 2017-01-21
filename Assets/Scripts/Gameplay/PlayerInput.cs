using UnityEngine;

public class PlayerInput : MonoBehaviour {

    public delegate void PlayerTouchEvent(Vector3 touch);
    public static event PlayerTouchEvent OnPlayerOneTouchDown;
    public static event PlayerTouchEvent OnPlayerTwoTouchDown;

    public InputController inputController;

	// Use this for initialization
	void Start () {
		
	}

    void SplitTouches(Vector3 touches){

        var viewportTouch = Camera.main.WorldToViewportPoint(touches);

        if(viewportTouch.x < 0.5){
            if (OnPlayerOneTouchDown != null) OnPlayerOneTouchDown(touches);
        }
        else{
            if (OnPlayerTwoTouchDown != null) OnPlayerTwoTouchDown(touches);
        }
    }
}
