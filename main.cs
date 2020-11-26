using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
  public static void Main()
  {
    string [] students = {"Henry","David","Tom"};
    LinkedList<string> list = new LinkedList<string>(students);
    var newNode = list.AddLast("Brad");
    list.AddBefore(newNode, "Emma");
    list.RemoveFirst();
    
    foreach (var stu in list) {
         Console.WriteLine(stu);
      }

    //ejemplo 2  
    LinkedList<int> numeros = new LinkedList<int>();
            //traer un nodo de otro array y empatarlo al array actual 
            LinkedListNode<int> nodo = new LinkedListNode<int>(20); 
            numeros.AddFirst(nodo);
    
    //creamos un arrar dentro del linkelist
    foreach(int numero in new int[]{10,8,6,4,2,0}){
      //este metodo permite posicionar el ultimo nodo del array al inicio
      //numeros.AddFirst(numero);
      //este metodo permite posicionar el primer nodo del array al inicio
      numeros.AddLast(numero);
      //numeros.Remove(0);
    }
    numeros.AddFirst(14);//añadir un nuevo nodo
    foreach(int numero in numeros){
      Console.WriteLine(numero);
    }
    
  }
}
