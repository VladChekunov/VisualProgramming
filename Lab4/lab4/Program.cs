using System;
using System.Collections.Generic;
using Gtk;

public class GenericsSet<T>{
	
	public class Node: IEquatable<Node>{
		public Node(T tdata){
			next = null;
			prew = null;
			data = tdata;
		}

		private Node next;
		public Node Next{
			get { return next; }
			set { next = value; }
		}

		private Node prew;
		public Node Prew{
			get { return prew; }
			set { prew = value; }
		}

		private T data;
		public T Data{
			get { return data; }
			set { data = value; }
		}
		public bool Equals(Node obj){
			if (obj==this) {
				return true;
			} else {
				return false;
			}
		}
	}

	private Node head;
	private Node tail;
	private int count;
	public GenericsSet(){
		head = null;
		tail = null;
		count = 0;
	}

	public void Add(T t)
	{
		Node n = new Node(t);
		if (head == null) {
			head = n;
			tail = n;
		} else {
			n.Prew = tail;
			n.Next = null;
			tail.Next = n;
			tail = n;
		}
		count++;
	}
	public Node Get(int Index){
		Node current = head;
		for (int i = 0; i < Index; i++) {
			current = current.Next;
		}
		return current;
	}

	public int GetCount(){
		return count;
	}
	//For print list
	public IEnumerator<T> GetEnumerator()
	{
		Node current = head;
		while (current != tail)
		{
			yield return current.Data;
			current = current.Next;
		}
	}

}

namespace lab4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();

		}
	}
}
