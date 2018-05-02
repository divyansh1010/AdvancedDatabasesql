/*
 * Name: Divyansh Sharma
 * Date: 30/10/17
 * @Version 1.0
 * Purpose: Modify the card class so the
setValue() method does not allow a card’s value to be less than 1 or higher than 13. If
the argument to setValue() is out of range, assign 1 to the card’s value.
 */
package war2;

/**
 *
 * @author divyansh sharma
 */
 public class Card
{

    private int cardnum; 
    private char suit; 
    
    //Constructors
    public Card(char suit, int cardnum){
        this.cardnum = cardnum;
        this.suit = suit;
    }//end of construcor
    
    //Get method for card
    public int getCardNumber(){
        return cardnum; 
    }//end getCard method
    
    //Set method for card
    public void setCardNumber(int cardnum){
        this.cardnum = cardnum;
    }//end of SetCard method
    
    @Override
    public String toString(){
    
        StringBuilder displayCard = new StringBuilder();
        
        
        switch(cardnum){
          
            case 11:
                displayCard.append("Jack");
                break;
            case 12:
                displayCard.append("Queen");
                break;
            case 13:
                displayCard.append("King");
                break;
            case 14:
                displayCard.append("Ace");
                break;    
            default:
                displayCard.append(cardnum);
                break;
        }
        
        displayCard.append(" of "); 
        
        switch(suit){
            case 0:
                displayCard.append("Spades");
                break;
            case 1:
                displayCard.append("Hearts");
                break;
            case 2:
                displayCard.append("Clubs");
                break;
            case 3:
                displayCard.append("Diamonds");
                break;
           
        }
        
        
        return displayCard.toString();
    }//end toString
    
  }

  

