/**************************************************************************
* Source File	:  BankAccount.cs
* Author                   :  BETSCH
* Project name         :  Fulbank* Created                 :  10/05/2022
* Modified   	:  10/05/2022
* Description	:  Definition of the class BankAccount
**************************************************************************/

using System;

namespace UML
{
	public  class BankAccount  : UML.MoneyInterface 				
	{
		//Inners Classifiers
		
		
		//Attributes
			
		  
		 
		 	private
		  Caractère variable BankAccount_iban; 
		
		//Attributes Association
		
				 public UML.User own;
				 public UML.AccountType is;
				public UML.InternalOperation[] int_receive;
				public UML.Operation[] pay;
				public UML.Conversion[] convert;
	
		
	
		

				
		//Operations
		 	
		 
		

	} // End Class BankAccount
} // End Namespace UML

