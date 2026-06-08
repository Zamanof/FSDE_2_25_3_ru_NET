/*
 - Data Types
    - Value Types
       - struct
       - create in stack (LIFO)
       - create without new keyword
       - compare by value
       - copy value
       - 
    - Reference Types
      - class
      - create Heap
      - create with new keyword
      - compare by reference
      - copy reference
      - Garbage Collector     
 */

// Value Types
bool check = false;         // System.Boolean   - 1 byte
char symb = 'a';            // System.Char      - 2 byte
byte byt = 255;             // System.Byte      - 1 byte
sbyte sbyt = 127;           // System.SByte     - 1 byte

short shrt = 256;           // System.Int16     - 2 byte
ushort ushrt = 256;         // System.UInt16    - 2 byte
int numb = 25;              // System.Int32     - 4 byte
uint numb1 = 25;            // System.UInt32    - 4 byte
long numb3 = 25;            // System.Int64     - 8 byte
ulong numb4 = 25;           // System.UInt64    - 8 byte

float temperture = 36.6f;   // System.Single    - 4 byte
double temperture1 = 36.6;  // System.Double    - 8 byte

decimal number = 398.125m;  // System.Decimal   - 16 byte

// Reference type
string name = "Nadir";
string name1 = new string("Nadir");
string foo = name;
Console.WriteLine(name == name1);

name = "Salam";
Console.WriteLine(foo);


