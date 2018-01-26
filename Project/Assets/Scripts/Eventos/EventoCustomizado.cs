using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "EventoCustomizado", fileName = "NovoEvento")]
public class EventoCustomizado : ScriptableObject
{
    List<EventListener> clientes;

    void OnEnable()
    {
        this.clientes = new List<EventListener>();
    }

    public void dispararEvento()
    {
        for (int i = 0; i < this.clientes.Count; i++)
        {
			this.clientes[i].reagir.Invoke();
        }
    }
    public void adicionarListener(EventListener cliente)
    {
        this.clientes.Add(cliente);
    }
    public void removerListener(EventListener cliente)
    {
        this.clientes.Remove(cliente);
    }

}
