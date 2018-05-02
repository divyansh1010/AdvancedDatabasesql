/*
 * Name: Divyansh Sharma
 * Date: 30/10/17
 * @Version 1.0
 * Purpose: To modify the
application so the suit and the value both are chosen randomly. Using two card
objects play a very simple version of the card game War. Deal two cards – one for the
computer and one for the player – and determine the higher card, then display a
message indicating whether the cards are equal, the computer won, or the player won. 
 */
package war;

import java.util.ArrayList;
import java.util.Collections;
import java.util.LinkedList;
import java.util.List;
import java.util.Random;

/**
 *
 * @author divyansh sharma
 */
public class War {

    /**
     * @param args the command line arguments
     */
     public static void main(String[] args) {
        //ArrayList for Deck of Cards
        List<Card> Deck = new ArrayList<Card>(); 
        //Four suits 
        for(int x=0; x<3; x++){  
            
            //13 ranks
            for(int y=2; y<15; y++){     
                Deck.add(new Card((char) x,y)); 
            } //end of rank for loop
        }//end of suit for loop
        
        
        //Card Shuffle
        Collections.shuffle(Deck, new Random()); 
        
        //Player deck
        LinkedList<Card> deck1 = new LinkedList<Card>();
        //Computer deck
        LinkedList<Card> deck2 = new LinkedList<Card>();
        
        //player Cards
        deck1.addAll(Deck.subList(0, 25));   
        //computer cards       
        deck2.addAll(Deck.subList(26, Deck.size()));
        
        while(true){
            Card pCard = deck1.pop(); 
            Card comCard = deck2.pop();
            
            //show the card
            System.out.println("Player " + pCard.toString());
            System.out.println("Computer " + comCard.toString());
            
          
            if(pCard.getCardNumber() > comCard.getCardNumber()){
                deck1.addLast(pCard);  
                deck1.addLast(comCard);  
                System.out.println("Player wins");
            }//end of if
 
             else if(pCard.getCardNumber() < comCard.getCardNumber()){
                deck2.addLast(pCard);   
                deck2.addLast(comCard);  
                System.out.println("Computer wins");
            }//end else if
            else
                 System.out.println("Its a Tie!");
            
            
            
            
            if(deck1.size()>deck2.size() ){
                System.out.println("Game Over");
                break;
            }
            else if(deck2.size()>deck1.size()){
                System.out.println("Game Over");
                break;
            
        }//end while  

    } // end of main
}// end of class
}