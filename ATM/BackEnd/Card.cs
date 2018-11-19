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


}
    