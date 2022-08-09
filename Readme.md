# C# Applications

- .NET Framework
	- Basic Building Blocks
		- Comman Language Specifications (CLS)
			- Set of Rules for .NET Languages 
			- e.g.
				- Syntaxes
				- Expressions MUST be LHS =  RHS
					- Consider Using TypeCasting for Data
				- If a class and its method is used in Source-Code, then the code  file MUST use the namespace in which that class is Present
			- The Language Specific Compilaters
				- C# Compiler
				- VB.NET Compiler
				- F#
		- Common Type System (CTS)
			- Used o Define all Types (aka Data Types) those are used to Store Data
			- Used by CLS
			- The 'Type' is the Higest Level Type-Declaration, under the 'System' Namespace
				- System.Type
					- This will be used to detech which type of data can be stored in a variable
				- The System.Object, is a highest-level data types
# Data Types
- Numeric
	- int, unint (4 bytes), System.Int32, System.UInt32 (CTS Types)
	- short, ushort (2 bytes), System.Int16, System.UInt16 (CTS Types)
	- byte, (1 byte), System.Byte (CTS Types)
	- long, ulong (8 bytes), System.Int64, System.UInt64 (CTS Types)
	- float (4 bytes),  System.Float32 (CTS Types)
	- double (8 bytes), System.Float64 (CTS Types)
	- decimal, (16 bytes), System.decimal  (CTS Types)
- Text
	- char, 2 bytes, System.Char
	- string, length of the string * 2 , System.String
- Boolean
	- bool
- Date
	- date, System.DateTime
- Collection
	- Types of In-Memory Data Collection
			
		- Framework Class Library (FCL)
			- Contains Standard Libraries with predefined set of classses grouped under 'Namespaces'
			- We use these classes while developing application by writing the code
			- The 'System' the highest level namespace
				- System.dll
			- System.Data, For Database
			- System.Collections, For In-Memory Data Mgmt
			- System.Web, for Web Apps
			- System.IO for Files
			- ..... an so on
- Input and Output Types (aka Classes)
	- System.Console
		- Class for Input/Output for Console Apps
		- Methods
			- Output
				- Write(), Print a string 
				- WriteLine(), print string on new line
			- Input
				- Read(), Read a Current String
				- ReadLine(), Read a  Line
				- ReadKey(), read any key
# Casting of Types
	- This is required in following cases
		- The RHS is generating a result which is not in the range of the LHS type 
			- If RHS returns decimal/long/string, then it cannot be stored into the integer
		- The RHS retuen value which does not match with the LHS type
			- if RHS return string and LHS is int/long/ etc. then better cast it
	- Casting Class
		- The 'Convert' class
		- Methods
			- ToInt32(), ToDecimal(), ToFloat(), ToDouble(), etc
# Code Compilation
- C# Source Code ----> Language Specific Compiler (C# Compiler)----> Generate A Compiled Output
	- Outpt Types from the Cource Code
		- .exe
		- .dll
# Debugging
	- F9, to apply breakpoint on the code so that the debugging can start
	- F11, the step into, to debug each line including a method call i.e. all lines for the method
	- F10, the strp over,  to debug each line by excluding method lines
# Asssembly
	- Compiled Output from the .NET Application
	- The Group of classes in the Program
	- The Output which is used for distribution to other application (.dll) or the self executable application itself (.exe)
		- The portable executable file (.PE), means can be shared across diveds on one machine and on other machines and will be executed if the targtt machine contains .NET Framework 
	- The Intermidiate Language Dis-Assembler
		- Installed when the .NET Frwk is installed
		- C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools\ildasm.exe
# C# Programming
- Fundamentals
	- Code Statements
	- Methods
		- Block of Re-Usable Statements		
			- One-Way Methods
				- Does not return anything
				- May Accepts Input Parameters
			- Two-Way Methods
				- Method that retuns a value or a parameter
				- May Accepts Input Parameters 
	- Conditional Statements
	- Type Manipulations
		- String Data Type
			- High-Level Language Agonostic Data Type
			- Powerfull because, it can store large stream of characters in it
			- The 'string' as declaration of the Type 'System.String'
			- This is a Reference Type
			- TO Initialize a string to 0 as length use 'string.Empty' instead of ""
			- This is an Array of Characters
				- Alphabet
				- Numeric Characters
				- Special Chaarcters
			- Since this is an Array, we can use the Loops aka Iteration to read data from String
				- for..loop
				- while..loop
				- do..while
				- Very Important
					- for..each loop
			- Being a Reference type is has following
				- Property
					- length
				- Methods
					- ToUpper()
					- ToLower()
					- SubStr()
	- Collection Foundation
		- Arrays
			- System.Array is a Type (aka class)
			- Any array declaration of any datatype will be a default instance of array class
			- The 'Length' is a property
			- Sort(), IndexOf(), LastIndexOf(), ect.
	- Collection Framework
		- In-Memory Data Store Classes
			-  USe Collections to Store UBound Data (Unlimitted data)
				- ArrayList
				- Queue
				- Stack
				- SortedList
			- Each Entry in collection is stored as 'object'
			- To Read an entry from collection for a specific type, the CLR has to read a type  first and then read its value, this is known as 'UnBoxing' and this takes 2-CPU cycles for each entry in the class (this reduces performance)
		- Practices to be followed while using the Collections
	- Using Scalable Coding using Reference Types
		- The 'ref'
			- Receive the Reference of the Variable being processed
			- Make sure that the variable is initialized before its reference passed to the method
		- The 'out'
			- Like Ref, used to pass the reference of actual parameter to a method, but the actual parameter need not have any initial value 
	- Object Oriented Programming
		- Applied OOPs
		- Classes
			- Members
				- Data Members (Generally Private to class)
				- Smart Fields aka Properties
					- A public get/set encapsulation over the Private Data Members
					- The property can immedialy validate the private member in its 'set' method section
						- The 'set' will be called when a value is assigned to a property
						- The 'get' will be called when the value is read from the Property
			- Methods
				- Behaviors aka Logic defined Around Members
		- Access Specifier
			- Rules or Guidelines for defining access of members and methods of the class inside the application
			- private : Within the declaring class

			- protected: WIthin the declarting class and its base class

			- public: Across all callers / users of the class

			- internal: Within the namespace where the declaing class is present  (aka Public to namespace)

			- protected internal: Like internal and also accessible in the derived class of other namespace

		- Access Modifiers
			- Behavior applied to class and its members
			- abstract: If applied tol the class then the class MUST be inherited and if applied to the method then the method MUST be Overriden by the deribed class. The abstract method does not have any implementation.

			- sealed: If applied on the class then class cannot be inherited and if applied on the method then the method cannot be overriden.

			- virtual: Applied on the method. Then the method has an implementation and this cane be overidden by the derived class or the derived class may use the method implementation of base as it it.

			- overrides: Used by the method from the derived class to override the base class abstract as well as virtual methods

			- new: Applied on the method of the deribed class to 'hide' the matching method of the base class

			- static: The member is accessed using the class name

		- Classes Designing Strategy
			- IN the system based on the use of the class define it
			- e.g.
				- If the class is used to pass data across various methods, then define the class as 'Entity Class' OR 'Data Transfer Object (DTO)' OR 'Value Object (VO)'.
				- If the class is used for defining behavior  (aka logic) then make its containing public/private/protected/internal/protected internal/static member methods
				    
		- Inheritence
		- Polymorphism
		- Interfaces
	- Generics
		- Best Use of Collections
		- They are the Templates for storing Data
		- Once the Template is given a Specific Type (Primptive Type or Custom CLR type) it will always uses the Same type throught the execution
		- The BEST REPLACEMENT FOR COLLECTIONS
			- No Boxing and UnBoxing
		- System.Collections.Generic;
			- List<T>
			- LinkedList<T>
			- Stack<T>
			- Queue<T>
			- .... and many more
		- The 'T' is a Template Parameter which can be 'typed-to' any stanadard or custome CLR Type
				- List<int> this will create a list instance only for integer values in list
				- List<string> the list instance only for string
				- List<Staff> the list imnstance only for Staff
		- BAsed on the type  for 'T', the CLR will create a copy of Generic class for the type in 'BINARY FORMAT'
	- Event Driven Programming
		- Delegates
		- Events
	- Applied C#
		- Lambdas
		- Extension Methods
		- Anonymous Types
		- Languag eIntegrated Queries (LINQ)
	- Threading
		- Multi-Threading
		- Parallel Programming

	