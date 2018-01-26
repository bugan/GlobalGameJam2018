using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventListener : MonoBehaviour
{
    public EventoCustomizado evento;
    public UnityEvent reagir;

    void OnEnable()
    {
		this.evento.adicionarListener(this);
    }

    void OnDisable()
    {
		this.evento.dispararEvento();
		this.evento.removerListener(this);
    }
}
