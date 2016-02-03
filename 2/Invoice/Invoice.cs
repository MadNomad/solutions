using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    class Invoice
    {
        private int account;
        private string customer;
        private string provider;
        private string article;
        private int quantity;
        private double summ;
        private const int TaxFee = 20;

        public Invoice(int acc, string cust, string prov)
        {
            account = acc;
            customer = cust;
            provider = prov;
        }
        
    }

    class Item
    {
    	private int itemArt;
    	private string itemName, itemPrice;
    	public int itemQuantity;
    	
    	public Item (int art, string name, string price)
    	{
    		itemArt = art;
    		itemName = name;
    		itemPrice = price;
    		itemQuantity = 0;
    	}
    	
    }
    
    class Order
    {
    	int orderNum
    	{
    		get 
    	}
    	
    	
    	public int CreateOrder (Invoice invoice)
    	{
    		
    	}
    	
    	public void AddItem (Item item, int quantity)
    	{
    		itemQuantity = quantity;
    		item.itemQuantity = quantity;
    	}

    }
}
