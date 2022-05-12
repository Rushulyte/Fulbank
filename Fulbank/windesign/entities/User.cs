/**************************************************************************
* Source File	:  User.cs
* Author                   :  BETSCH
* Project name         :  Fulbank* Created                 :  10/05/2022
* Modified   	:  10/05/2022
* Description	:  Definition of the class User
**************************************************************************/

using System;

namespace UML
{
	public  class User  				
	{
		//Inners Classifiers
		
		
		//Attributes
			
		  
		 
		 	private
		  int User_id; 
		 	private
		  Caractère variable User_firstname; 
		 	private
		  Caractère variable User_lastname; 
		 	private
		  Caractère variable User_email; 
		 	private
		  Caractère long variable User_authentication_string; 
		 	private
		  Caractère variable User_phone; 
		 	private
		  Caractère variable User_address; 
		 	private
		  Caractère long variable User_salt; 
		 	private
		  Date et Heure User_created_date; 
		
		//Attributes Association
		
				public UML.BankAccount[] own;
				 public UML.UserType belong;
				public UML.Wallet[] have;
	
		
	
		

				
		//Operations
		 	
		 
		

	} // End Class User
} // End Namespace UML

