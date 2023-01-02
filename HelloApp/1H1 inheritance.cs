
class A // A is base/parent/super class and B is derived/child/sub
{
 public int x;
}

class B : A // means B inherits A, means A is father of A, also known as single inheritance bcoz one class inheritance another
{
  public string y;
}

class C : B // multilevel inheritance
{
 public byte z;

 public void Test (){}
}

interface ID
{
   
}


// Multiple inheritance
class E:B, ID  // CLASS E inherits B and implements D
{
    
}


