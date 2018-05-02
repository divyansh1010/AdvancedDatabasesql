/*
 * Name: Divyansh Sharma
 * Date: 30/10/17
 * @Version 1.0
 * Purpose: To modify the game using the newly modified card class so that when a tie is declared,
that each player “puts down 10 cards each” and compares the 11th card to see if there is a
clear winner. If there is a tie, repeat the process until there is a clear winner. The table
below shows four typical executions
 */
package war2;

import java.util.ArrayList;
import java.util.Collections;
import java.util.LinkedList;
import java.util.List;
import java.util.Random;

/**
 *
 * @author divyansh sharma
 */
public class War2 {

    /**
     * @param args the command line arguments
     */
     public static void main(String[] args) {
     
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
            System.out.println("Player card " + pCard.toString());
            System.out.println("Computer card " + comCard.toString());
            
          
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
            
            else { 
                System.out.println("Tie!"); 
                  System.out.println("War!");
                //cards for both player and computer
                List<Card> player = new ArrayList<Card>(); 
                List<Card> computer = new ArrayList<Card>();
                
                for(int x=0; x<10; x++){ 
                 
                    if(deck1.size() == 0 || deck2.size() == 0 ){    
                        break;
                    }//end if
                    
                   player.add(deck1.pop());  
                    computer.add(deck2.pop());                  
            //show the card
            System.out.println("Player Card " +player.toString() );
            System.out.println("Computer Card"  + computer.toString());
              System.out.println("Discard " );
                  
                }//end for
                
                
                if(player.size() == 10 && computer.size() == 10 ){
                    System.out.println("player card " + player.get(0).toString());
                    System.out.println("computer card " + computer.get(0).toString());
                  //player condition to win
                    if(player.get(2).getCardNumber() > computer.get(2).getCardNumber()){
                        deck1.addAll(player); 
                        deck1.addAll(computer);
                        System.out.println("Player wins");
                    }//end if
                    else{
                        deck2.addAll(player); 
                        deck2.addAll(computer);
                        System.out.println("Computer wins");
                    }   //end else             
                }
                
            }
            //game over 
          if(deck1.size()>deck2.size() ){
                System.out.println("Game Over");
                break;
            }
            else if(deck2.size()>deck1.size()){
                System.out.println("Game Over");
                break;
        }//end while  

    }//end main       
}//end  class
}