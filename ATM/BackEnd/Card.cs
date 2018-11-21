using System;

public class Card
{
    public string CardNumber{get; set;}
    private string Pin{get; set;}
    public DateTime ExpiryDate{get;}
    public int Cvc{get;}
    public CardType Type{get;}
    private int nbErrors;
    public bool IsBlocked
    {
        get{ return this.nbErrors >= MAXNBERRORS; }
    }

    private const int MAXNBERRORS = 3;

    public Card(string cardNumber, string pin, DateTime expiryDate, int cvc, CardType type)
    {
        this.CardNumber = cardNumber;
        this.Pin = pin;
        this.ExpiryDate = ExpiryDate;
        this.Type = type;
        this.nbErrors = 0;
    }


    public bool CheckPin(string pin)
    {
        if(this.IsBlocked)
            throw new Exception("This card is blocked.");
        
        if(this.Pin == pin)
        {
            this.nbErrors = 0;
            return true;
        }
        else
        {
            this.nbErrors++;
            return false;
        }
    }

    //duplicated method here to allow sonar cloud to find a problem 
    public void LogOut(bool printReceive)
    {
        if (!this.isLogged)
        {
            throw new InvalidOperationException("No user is logged in.");
        }

        if (printReceive)
        {
            this.PrintReceive();
        }

        this.GiveBackCard();
    }


}
    