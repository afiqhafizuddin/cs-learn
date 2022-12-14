# **Value types and reference types**

C# contains many different data types available. Choosing the right one requires one to understand what every data types do.

### **What is data?**

1. In SWE, data is essentially value that is stored in the computer's memory as a series of bits or ones and zeros.
2. Eight bits = one byte. We represent 256 different combinations with just 8 bits
3. To work with large values beyond 255, you'll need to store more bytes

### **What about textual data?**

1. System like ASCII - to represent lowercase and uppercase, numbers, tabs, newlines, math symbols etc by using a byte.

### **What is data type?**

1. Data type is a programming language construct that defines how much memory to reserve for a value.
2. Many data types - programming language designers understand that it will be used for many applications and sizes of data

### **Value vs Reference Types**

1. Fundamental difference between the two - where those values are temporarily stored in memory as your apps executes.
2. Where the value is stored affects hoe the .NET runtime manages the life cycle of the value - declaration (birth), assignment and retrieval (life) and finalization (death).

### **Simple value type**

1. Set of predefined types provided by C# as keywords.
2. Keywords are merely aliases for predefined types defined in the .NET Class Library.

### **Integral Types**

1. Integral type is a simple value type that represents whole numbers (non-fractional).
2. The most famous data type in this category is `int`.

#### **Signed Integral Types**

- Signed type uses its bytes to represent an equal number of positive and negative numbers.

#### **Unsigned Integral Types**

- Unsigned type uses its bytes to represent only positive numbers.

### **Floating-point Types**

A floating is simply a value that represents fractional number.

1. Need to consider the precision level each type allows
2. Consider the manner in which the value is stored.
3. `float` and `double` are stored in base 2 (binary) whereas `decimal` is stored in base 10 (decimal)

## **Reference Type**

Reference types include array, classes and string.

### **How reference types are different from value types**

#### Value types memory allocation

1. Value types are stored in a region of memory called the _stack_.
2. The stack is a memory that is allocated to the code that is currently running on the CPU.
3. When the stack frame is finished running, the stack memory is cleared.

#### Reference type memory allocation

1. Reference type variable store its value in the _heap_.
2. _Heap_ is a memory region that is shared across multiple applications running on the operating system at the same time
3. The .NET runtime communicates with the OS to determine what addresses are available.
4. The .NET runtime stores the value and returns the address to the variable.
5. When the code needs to use the values stored in the variable, the .NET runtime seamlessly retrieved the value from the address.
