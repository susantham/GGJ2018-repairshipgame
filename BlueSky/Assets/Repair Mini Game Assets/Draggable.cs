using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

	public Transform parentToReturnTo = null;

    public enum Slot {LEFT, RIGHT, TOP, BOTTOM, OTHER};
    public Slot typeOfItem = Slot.BOTTOM;
	
	public void OnBeginDrag(PointerEventData eventData) {
		//Debug.Log ("OnBeginDrag");

		parentToReturnTo = this.transform.parent;
		this.transform.SetParent( this.transform.parent.parent );

		GetComponent<CanvasGroup>().blocksRaycasts = false;
	}

	public void OnDrag(PointerEventData eventData) {
		//Debug.Log ("OnDrag");

		this.transform.position = eventData.position;
	}
	
	public void OnEndDrag(PointerEventData eventData) {
		//Debug.Log ("OnEndDrag");
		this.transform.SetParent( parentToReturnTo );
		GetComponent<CanvasGroup>().blocksRaycasts = true;
	}
	


}
