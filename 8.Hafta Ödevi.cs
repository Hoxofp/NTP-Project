using System;

// 1. soru 

public class Person
{
	public string name { get; set; }
	public string phoneNumber { get; set; }
	public int emailAddress { get; set; }

	public void purchaseParkingPass()
	{

	}

}
public class Student : Person
{
	public int studentNumber { get; set; }
	public int averageMark { get; set; }
	public bool isEligibleToEnroll(string eligible)
	{
		return true;
	}
	public int getSeminarsTaken()
	{
		return 0;
	}

}
public class Professor : Person
{
	public int salary 
	{
		get {  return 0; }
	}

	protected int staffNumber { get; set; }
	private int yearsOfService { get; set; }
	public int numberOfClasses { get; set; }	

}

public class Address
{
	public string street { get; set; }
	public string city { get; set; }
	public string state { get; set; }
	public string country { get; set; }
	public int postalCode { get; set; }	

	private bool validate()
	{
		return true;
	}
	public string outputAsLabel()
	{
		return string.Empty;
	}

}



// 2. soru



public class Animal
{
	public string type { get; set; }
	public string breed { get; set; }
	public bool carnivore { get; set; }

}
public interface IIdentifiable
{
	int UUID();
}
public class Pet: Animal, IIdentifiable
{
	private static int _idCounter = 0; 
	public int id { get; private set; }
	public PetInformation petinfo = new PetInformation();
	public string name { get; set; }
	public int age { get; set; }
	public Owner owner = new Owner();
	public Animal type = new Animal();

	public int UUID()
	{
		return id = ++_idCounter;
	}

	public void feed()
	{
		Console.WriteLine("The pet {0} is fed", type);
	}
	private bool isHerbivore()
	{
		return !carnivore;
	}
}

public class PetInformation
{
	public string[] traits { get; set; }
	public List<Vaccine> vaccines { get; set; } = new List<Vaccine>();
}

public class Vaccine
{
	public string name { get; set; }
	public string type { get; set; }

}

public class Owner : IExperienced
{
	public string name { get; set; }
	
}

public interface IExperienced
{

}

// 3.soru

public class Transaction
{
	protected int id { get; set; }
	public string name { get; set; }
	public string date { get; set; }
	public string address { get; set; }

	Reservation reservation = new Reservation();

	public void update()
	{
		//update fonksiyonu
	}

}

public class Customer
{
	protected int id { get; set; }
	public string name { get; set; }
	public string contact { get; set; }
	public string address { get; set; }
	protected int payment { get; set; }

	Transaction transaction = new Transaction();

	protected void update()
	{
		//update fonksiyonu
	}
}
public class Car
{
	protected int id { get; set; }
	public int details { get; set; }
	public string ordertype { get; set; }

	RentingOwner owner = new RentingOwner();

	public void processDebit()
	{
		//processDebit fonksiyonu
	}

}
public class Reservation
{
	protected int id { get; set; }
	public string details { get; set; }
	public string list { get; set; }

	public void confirmation()
	{
		//confirmation fonksiyonu
	}
}
public class RentingOwner
{
	protected int id { get; set; }
	public string name { get; set; }
	public string age { get; set; }
	public string contactnum { get; set; }
	private string username { get; set; }
	private string password { get; set; }

	public void verifyAccount()
	{
		//verifyAccount fonksiyonu
	}

}
public class Rentals
{
	protected int id { get; set; }
	public string name { get; set; }
	public string price { get; set; }
	public void add()
	{
		//add fonksiyonu
	}
}
public class Payment
{
	public int id { get; set; }
	public int cardnumber { get; set; }
	public string amount { get; set; }
	public void add()
	{
		//add fonksiyonu
	}
	public void update()
	{
		//update fonksiyonu
	}
}
