using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedListOperations{

public class Operations{
  string[] words;
         LinkedList<string> sentence;
         

public void addFirst(){
    try{
        bool isEmpty = !sentence.Any();
        string word;
        if (isEmpty)
        {
            Console.WriteLine("Please create list first");
          
        }
        else{
            Console.WriteLine("Please input word to add");
             word = Console.ReadLine();
sentence.AddFirst(word);
Display(sentence,$"Added word {word} to the first");
 Console.WriteLine("Successfully inserted");
        }


    }
    catch(Exception ex){
 Console.WriteLine(ex.Message);
    }

}
public void moveFirstToLast(){
      try{
        bool isEmpty = !sentence.Any();
        if (isEmpty)
        {
            Console.WriteLine("Please create list first");
           
        }
        else{
// Move the first node to be the last node.
        LinkedListNode<string> mark1 = sentence.First;
        sentence.RemoveFirst();
        sentence.AddLast(mark1);
        Display(sentence, "Move first node to be last node:");
        }
 

    }
    catch(Exception ex){
 Console.WriteLine(ex.Message);
    }
}

public void moveLastToFirst(){
try{
        bool isEmpty = !sentence.Any();
        if (isEmpty)
        {
            Console.WriteLine("Please create list first");
           
        }
        else{
     // Move the last node to be the first node.
     LinkedListNode<string> mark1 = sentence.First;
        mark1 = sentence.Last;
        sentence.RemoveLast();
        sentence.AddFirst(mark1);
        Display(sentence, "Move last node to be first node:");
        }
 

    }
    catch(Exception ex){
 Console.WriteLine(ex.Message);
    }
      
}


public void indicateLastOccurence()
{
     try{
         string occurenceOf;
        bool isEmpty = !sentence.Any();
        if (isEmpty)
        {
            Console.WriteLine("Please create list first");
           
        }
        else{
            Console.WriteLine("Please input node to find occurence");
             occurenceOf = Console.ReadLine();
      // Indicate the last occurence of 'the'.
        sentence.RemoveFirst();
        LinkedListNode<string> current = sentence.FindLast(occurenceOf);
       Console.WriteLine(occurenceOf);
         if (current.List == null)
        {
            Console.WriteLine("Node '{0}' is not in the list.\n",
                current.Value);
      
        }
else{
 StringBuilder result = new StringBuilder("(" + current.Value + ")");
        LinkedListNode<string> nodeP = current.Previous;

        while (nodeP != null)
        {
            result.Insert(0, nodeP.Value + " ");
            nodeP = nodeP.Previous;
        }

        current = current.Next;
        while (current != null)
        {
            result.Append(" " + current.Value);
            current = current.Next;
        }

        Console.WriteLine(result);
    
        }
 
}
       

    }
    catch(Exception ex){
 Console.WriteLine(ex.Message);
    }


       
}
public void changeLast(){
     try{
        bool isEmpty = !sentence.Any();
        string changeWith;
        if (isEmpty)
        {
            Console.WriteLine("Please create list first");
           
        }
        else{
            Console.WriteLine("Please input with what you want to replace?");
            changeWith = Console.ReadLine();
       sentence.RemoveLast();
        sentence.AddLast(changeWith);
      
        Display(sentence, "Change the last node with"+changeWith);
        }
 

    }
    catch(Exception ex){
 Console.WriteLine(ex.Message);
    }
  
}


public void addAfter(){

     try{
           string what, after;
        bool isEmpty = !sentence.Any();
        if (isEmpty)
        {
            Console.WriteLine("Please create list first");
           
        }
        else{
                 Console.WriteLine("Please input before which node?");
            after = Console.ReadLine();
              Console.WriteLine("Please input value to replace with");
            what = Console.ReadLine();
      LinkedListNode<string> current = sentence.Find(after);
     
     if (current.List == null)
        {
            Console.WriteLine("Node '{0}' is not in the list.\n",
                current.Value);
      
        }
        else{
          
     sentence.AddAfter(current, what);
     Display(sentence,$"Added word '{what}' after {after}");
        }
       
   
      
        }
 

    }
    catch(Exception ex){
 Console.WriteLine(ex.Message);
    }
      
}



public void addBefore(){

     try{
         string what, before;
        bool isEmpty = !sentence.Any();
        if (isEmpty)
        {
            Console.WriteLine("Please create list first");
           
        }
        else{
            Console.WriteLine("Please input before which node?");
            before = Console.ReadLine();
              Console.WriteLine("Please input value to replace with");
            what = Console.ReadLine();
      LinkedListNode<string> current = sentence.Find(before);
     
     if (current.List == null)
        {
            Console.WriteLine("Node '{0}' is not in the list.\n",
                current.Value);
      
        }
        else{
     sentence.AddBefore(current, what);
      Display(sentence,$"Added word "+what+" before "+before);
        }
       
   
      
        }
 

    }
    catch(Exception ex){
 Console.WriteLine(ex.Message);
    }
      
}


public void removeFist(){

      try{
        bool isEmpty = !sentence.Any();
        if (isEmpty)
        {
            Console.WriteLine("Please create list first");
           
        }
        else{
         sentence.RemoveFirst();
         Display(sentence,$"Removed first from list");
       
   
      
        }
 

    }
    catch(Exception ex){
 Console.WriteLine(ex.Message);
    }
      
      
}



public void remove(){

     try{
         string toRemove;
        bool isEmpty = !sentence.Any();
        if (isEmpty)
        {
            Console.WriteLine("Please create list first");
           
        }
        else{
            Console.WriteLine("Please input node to remove");
            toRemove = Console.ReadLine();
      LinkedListNode<string> current = sentence.Find(toRemove);
     
     if (current.List == null)
        {
            Console.WriteLine("Node '{0}' is not in the list.\n",
                current.Value);
      
        }
        else{
     sentence.Remove(current);
      Display(sentence,$"Removed word '{toRemove}' from list");
        }
       
   
      
        }
 

    }
    catch(Exception ex){
 Console.WriteLine(ex.Message);
    }
      
}



public void removeLast(){

       try{
        bool isEmpty = !sentence.Any();
        if (isEmpty)
        {
            Console.WriteLine("Please create list first");
           
        }
        else{
         sentence.RemoveLast();
         Display(sentence,$"Removed last from list");
       
   
      
        }
 

    }
    catch(Exception ex){
 Console.WriteLine(ex.Message);
    }
      
}
  private  void Display(LinkedList<string> words, string test)
    {
    
        Console.WriteLine(test);
        foreach (string word in words)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }

public void menu(){

    Console.WriteLine("1:Create List\n2:moveFirstToLast\n3:moveLastToFirst\n4:addFirst\n5:indicateLastOccurence\n6:changeLast\n7:addAfter\n8:addBefore\n9:Display\n10:remove\n11:removeFist\n12:removeLast");
}
public  void start(){

try {
int choice =0;
do{
Console.WriteLine("Please select from the following");
menu();
 choice = int.Parse(Console.ReadLine());

 switch (choice)
    {
        case 1:
        createList();
        break;
         case 2:
        moveFirstToLast();
        break;
         case 3:
        moveLastToFirst();
        break;
         case 4:
        addFirst();
        break;
         case 5:
        indicateLastOccurence();
        break;
         case 6:
        changeLast();
        break;
         case 7:
        addAfter();
        break;
         case 8:
        addBefore();
        break;
         case 9:
       Display(sentence,"The linked list values:");
        break;
         case 10:
        remove();
        break;
         case 11:
        removeFist();
        break;
         case 12:
        removeLast();
        break;
        default:

        Console.WriteLine("Please retry or press '0' to quit");
        break;
    }
}while(choice!=0);



}
    catch(Exception ex)
    {
Console.WriteLine(ex.Message);
    }
}
        public void createList(){

            try
            {
                Console.WriteLine("Please input length");
                int length =int.Parse(Console.ReadLine()) ;
                words = new string[length];
                for (int i = 0; i < words.Length; i++)
                {
                    Console.WriteLine($"Enter {i} letter");
                    words[i] = Console.ReadLine();
                }

                 sentence = new LinkedList<string>(words);

                 Display(sentence,"The linked list values:");
            }
            catch (System.Exception ex)
            {
                
                Console.WriteLine(ex.Message);
            
            }
        }
}

  
}