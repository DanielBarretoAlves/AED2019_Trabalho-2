# This is a good example of inheritance in C-Sharp
class *B* Received an method get from *A* this is how they can send atributes cross the classes families
	using System;

	public class A 
	{
		private int value = 10;

		public class B : A
		{
				public int GetValue()
				{
						return this.value;
				}     
		}
	}

	public class C : A
	{
	//    public int GetValue()
	//    {
	//        return this.value;
	//    }
	}

	public class Example
	{
			public static void Main(string[] args)
			{
					var b = new A.B();
					Console.WriteLine(b.GetValue());
			}
	}
	// The example displays the following output:
	//       10

this way I could perform an inheritance easily with code, and I was able to implement in my current project.

	using System;
	public class A 
	{
		private int value = 10;
		
		private string _name;
			internal string Name
			{
					get => _name;
					set => _name = value;
			}

		internal int GetValue()
				{
						return value;
				}   

		public class B : A
		{
					
		}
	}

	public class C : A
	{
	//    public int GetValue()
	//    {
	//        return this.value;
	//    }
	}

	public class Example
	{
			public static void Main(string[] args)
			{
					C ces = new C();
					ces.Name = "Daniel";
					Console.WriteLine(ces.GetValue());
					Console.WriteLine(ces.Name);
			}
	}
	// The example displays the following output:
	//       10